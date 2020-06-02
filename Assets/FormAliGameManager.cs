using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class FormAliGameManager : MonoBehaviour
{
    public GameObject textObj;
    public GameObject targetObj;
    public GameObject mugshotObj;
    public List<string> expressionNames;
    public List<GameObject> expressionObjs;
    private Text text;
    private TopicContainer tc;
    private float lineDuration = 5.0f;
    private float timer = 0f;
    public Conversation currentConversation;
    public Dictionary<string, Topic> topics = new Dictionary<string, Topic>();
    public GameObject thoughtSpawnerObj;
    private ThoughtSpawner thoughtSpawner;
    public Image progressCircle;
    public GameObject startOver;
    public GameObject credits;
    public Text topicsRemainingText;
    public AudioClip musicClip;
    public AudioSource musicSource;

    private string selectedTopic;
    private int topicsRemaining = 6;
    private int convoLineNum = 0;
    private List<string> alreadyDiscussed = new List<string>();
    private Conversation ender;
    public Dictionary<string, GameObject> expressions = new Dictionary<string, GameObject>();
    private GameObject currentTargetExpression;
    private GameObject currentMugshot;
    private bool conversationEnded = false;
    private bool goodConfession = false;
    private bool gameStopped = false;
    
    public class Conversation
    {
        public Line[] lines;
        public int pointMadeLine = -1;
        public bool pointMade = false;
        public string topic;
        public bool hot = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        musicSource.clip = musicClip;
        musicSource.Play();
    }

    public void Init()
    {
        text = textObj.GetComponent<Text>();
        thoughtSpawner = thoughtSpawnerObj.GetComponent<ThoughtSpawner>();
        tc = JsonUtility.FromJson<TopicContainer>(JSONContainer.gameJSON);
        for (int i = 0; i < tc.topics.Length; i++)
        {
            topics.Add(tc.topics[i].topic, tc.topics[i]);
        }
        for (int i = 0; i < expressionNames.Count; i++)
        {
            expressions.Add(expressionNames[i], expressionObjs[i]);
        }
        ender = CreateConversationEnder();
        StartRandomTopic();
    }

    Conversation CreateConversationEnder()
    {
        Line[] enderLines = new Line[8];
        enderLines[0] = new Line();
        enderLines[0].line = "Alice: Hey, come to think of it...";
        enderLines[0].mugshot = "A_Inquisitive";
        enderLines[1] = new Line();
        enderLines[1].line = "Alice: Don't you usually fly off right about now, while remembering you have something to do?";
        enderLines[1].mugshot = "A_Inquisitive";
        enderLines[2] = new Line();
        enderLines[2].line = "Marisa: Y-Ya don't say.";
        enderLines[2].mugshot = "M_Exasperated";
        enderLines[3] = new Line();
        enderLines[3].line = "Alice: You've been especially chatty today.";
        enderLines[3].mugshot = "A_Inquisitive";
        enderLines[4] = new Line();
        enderLines[4].line = "Alice: Did something weird happen?";
        enderLines[4].mugshot = "A_Inquisitive";
        enderLines[5] = new Line();
        enderLines[5].line = "Marisa: I dunno. Feelin' tired all of a sudden.";
        enderLines[5].mugshot = "M_Happy";
        enderLines[6] = new Line();
        enderLines[6].line = "Alice: Well, I hate to be the mom type, but you should go get some rest.";
        enderLines[6].mugshot = "A_Lecturing";
        enderLines[7] = new Line();
        enderLines[7].line = "Marisa: Yeah, you're right.";
        enderLines[7].mugshot = "M_Exasperated";
        Conversation enderConvo = new Conversation();
        enderConvo.lines = enderLines;
        return enderConvo;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameStopped)
        {
            topicsRemainingText.text = topicsRemaining + " things left to talk about";
            timer += Time.deltaTime;
            progressCircle.fillAmount = timer / lineDuration;
            if (timer >= lineDuration || (Input.GetKeyUp("space")))
            {
                ShowNextLine();
                timer = 0f;
            }
        }
    }

    void ShowNextLine()
    {
        if (convoLineNum >= currentConversation.lines.Length)
        {
            if (goodConfession)
            {
                text.text = "(Congratulations to Marisa! Her confession worked!)";
                gameStopped = true;
                startOver.SetActive(true);
                credits.SetActive(true);
                return;
            }
            if (conversationEnded)
            {
                text.text = "(Marisa failed! Game over!)";
                gameStopped = true;
                startOver.SetActive(true);
                credits.SetActive(true);
                return;
            } else
            {
                if (topicsRemaining <= 0)
                {
                    currentConversation = ender;
                    conversationEnded = true;
                    convoLineNum = 0;
                    thoughtSpawner.StopSpawning();
                    AdvanceConversation();
                    return;
                }
                else
                {
                    StartRandomTopic();
                }
            }
        } else
        {
            AdvanceConversation();
        }
    }

    void StartRandomTopic()
    {
        List<int> availableTopicNums = new List<int>();
        for (int i = 0; i < tc.topics.Length; i++)
        {
            if (!tc.topics[i].topic.Equals("Confess Fail") && tc.topics[i].topic.IndexOf(" Confession") == -1 && !alreadyDiscussed.Contains(tc.topics[i].topic))
            {
                availableTopicNums.Add(i);
            }
        }
        if (availableTopicNums.Count == 0)
        {
            currentConversation = ender;
            conversationEnded = true;
            convoLineNum = 0;
            thoughtSpawner.StopSpawning();
            AdvanceConversation();
        } else
        {
            int index = (int)Mathf.Floor(UnityEngine.Random.value * availableTopicNums.Count);
            Topic topic = tc.topics[availableTopicNums[index]];
            GetConversation(topic, true);
            convoLineNum = 0;
            topicsRemaining--;
            AdvanceConversation();
        }
    }

    void GetConversation(Topic topic, bool isTargetStart)
    {
        Conversation convo = new Conversation();
        convo.topic = topic.topic;
        Line targetStartLine = null;
        if (RequirementsFulfilled(topic.topic) || goodConfession)
        {
            convo.hot = true;
            convo.lines = new Line[topic.realTalk.lines.Length];
            for (int i = 0; i < convo.lines.Length; i++)
            {
                convo.lines[i] = topic.realTalk.lines[i];
            }
            convo.pointMadeLine = topic.realTalk.pointMade;
            targetStartLine = topic.realTalk.alicesOpening;
        }
        if (convo.lines == null)
        {
            convo.lines = new Line[topic.casualTalk.lines.Length];
            for (int i = 0; i < convo.lines.Length; i++)
            {
                convo.lines[i] = topic.casualTalk.lines[i];
            }
            convo.pointMadeLine = topic.casualTalk.pointMade;
            targetStartLine = topic.casualTalk.alicesOpening;
        }
        if (isTargetStart)
        {
            convo.lines[1] = targetStartLine;
            Line[] newLines = new Line[convo.lines.Length - 1];
            Array.Copy(convo.lines, 1, newLines, 0, newLines.Length);
            convo.lines = newLines;
            convo.pointMadeLine -= 1;
        }
        currentConversation = convo;
        convoLineNum = 0;
        thoughtSpawner.StartedNewTopic(currentConversation.topic);
    }

    void AdvanceConversation()
    {
        text.text = currentConversation.lines[convoLineNum].line;
        if (currentConversation.lines[convoLineNum].mugshot != null)
        {
            if (currentConversation.lines[convoLineNum].mugshot.StartsWith("A_"))
            {
                if (currentTargetExpression != null)
                {
                    currentTargetExpression.SetActive(false);
                }
                currentTargetExpression = expressions[currentConversation.lines[convoLineNum].mugshot];
            }
            else
            {
                if (currentMugshot != null)
                {
                    currentMugshot.SetActive(false);
                }
                currentMugshot = expressions[currentConversation.lines[convoLineNum].mugshot];
            }
            expressions[currentConversation.lines[convoLineNum].mugshot].SetActive(true);
        }
        if (!currentConversation.pointMade && currentConversation.pointMadeLine != -1 && convoLineNum == currentConversation.pointMadeLine)
        {
            currentConversation.pointMade = true;
            alreadyDiscussed.Add(currentConversation.topic);
        }
        convoLineNum++;
    }

    public void ChangeTopic(string topic)
    {
        if (topicsRemaining <= 0)
        {
            return;
        }
        thoughtSpawner.Refresh();
        if (topic.Equals("Confess!"))
        {
            thoughtSpawner.StopSpawning();
            if (currentConversation.hot && currentConversation.pointMade)
            {
                goodConfession = true;
                GetConversation(topics[currentConversation.topic + " Confession"], false);
            } else
            {
                GetConversation(topics["Confess Fail"], false);
                topicsRemaining = 0;
            }
            return;
        }
        if (alreadyDiscussed.Contains(topic) && !RequirementsFulfilled(topic))
        {
            Line[] newConvoLines = new Line[currentConversation.lines.Length + 4];
            newConvoLines[convoLineNum] = topics[topic].casualTalk.lines[0];
            newConvoLines[convoLineNum + 1] = new Line();
            newConvoLines[convoLineNum + 1].line = "Alice: Didn't we talk about that already?";
            newConvoLines[convoLineNum + 1].mugshot = "A_Side";
            newConvoLines[convoLineNum + 2] = new Line();
            newConvoLines[convoLineNum + 2].line = "Marisa: Yeah... (Oops!)";
            newConvoLines[convoLineNum + 2].mugshot = "M_Exasperated";
            newConvoLines[convoLineNum + 3] = new Line();
            newConvoLines[convoLineNum + 3].line = "Marisa: Where were we?";
            newConvoLines[convoLineNum + 3].mugshot = "M_Exasperated";
            Array.Copy(currentConversation.lines, convoLineNum, newConvoLines, convoLineNum + 4, currentConversation.lines.Length - convoLineNum);
            currentConversation.lines = newConvoLines;
            currentConversation.pointMadeLine += 2;
            topicsRemaining--;
            return;
        }
        if (!currentConversation.pointMade)
        {
            GetConversation(topics[topic], false);
            Line[] newConvoLines = new Line[currentConversation.lines.Length + 2];
            newConvoLines[0] = currentConversation.lines[0];
            newConvoLines[1] = new Line();
            newConvoLines[1].line = "Alice: That's... an abrupt change in topic.";
            newConvoLines[1].mugshot = "A_Neutral";
            newConvoLines[2] = new Line();
            newConvoLines[2].line = "Marisa: Yeah... (Oops!)";
            newConvoLines[2].mugshot = "M_Exasperated";
            Array.Copy(currentConversation.lines, 1, newConvoLines, 3, currentConversation.lines.Length - 1);
            currentConversation.lines = newConvoLines;
            currentConversation.pointMadeLine += 2;
            topicsRemaining -= 2;
            return;
        }
        GetConversation(topics[topic], false);
        topicsRemaining--;
    }

    private bool RequirementsFulfilled(string t)
    {
        Topic topic = topics[t];
        bool requirementsFulfilled = true;
        if (topic.leadIns != null)
        {
            for (int i = 0; i < topic.leadIns.Length; i++)
            {
                if (!alreadyDiscussed.Contains(topic.leadIns[i]))
                {
                    requirementsFulfilled = false;
                }
            }
            return requirementsFulfilled;
        } else
        {
            return false;
        }
    }

    public void StartOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadCredits()
    {
        SceneManager.LoadScene(2);
    }
}
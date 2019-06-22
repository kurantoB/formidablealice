using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

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

    private string selectedTopic;
    private int topicsRemaining = 6;
    private int convoLineNum = 0;
    private List<string> alreadyDiscussed = new List<string>();
    private Conversation ender;
    private Conversation currentConversation;
    public Dictionary<string, GameObject> expressions = new Dictionary<string, GameObject>();
    private GameObject currentTargetExpression;
    private GameObject currentMugshot;
    private bool conversationEnded = false;
    
    class Conversation
    {
        public string[] lines;
        public string[] mugshots;
        public int pointMadeLine;
        public bool pointMade = false;
        public string topic;
        public bool hot = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        text = textObj.GetComponent<Text>();
        StreamReader reader = new StreamReader("Assets/game.json");
        tc = JsonUtility.FromJson<TopicContainer>(reader.ReadToEnd());
        for (int i = 0; i < expressionNames.Count; i++)
        {
            expressions.Add(expressionNames[i], expressionObjs[i]);
        }
        ender = CreateConversationEnder();
    }

    Conversation CreateConversationEnder()
    {
        return null;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= lineDuration) {
            ShowNextLine();
            timer = 0f;
        }
    }

    void ShowNextLine()
    {
        if (convoLineNum == currentConversation.lines.Length)
        {
            if (conversationEnded)
            {
                // Game over
            } else
            {
                if (topicsRemaining == 0)
                {
                    currentConversation = ender;
                    conversationEnded = true;
                    convoLineNum = 0;
                    AdvanceConversation();
                    return;
                }
                else
                {
                    currentConversation = GetConversation(true);
                    convoLineNum = 0;
                    AdvanceConversation();
                    return;
                }
            }
        } else
        {

        }
    }

    Conversation GetConversation(bool isTargetStart)
    {
        List<int> availableTopicNums = new List<int>();
        for (int i = 0; i < tc.topics.Length; i++)
        {
            if (!alreadyDiscussed.Contains(tc.topics[i].topic))
            {
                availableTopicNums.Add(i);
            }
        }
        int index = (int)Mathf.Floor(Random.value * availableTopicNums.Count);
        Topic topic = tc.topics[availableTopicNums[index]];
        Conversation convo = new Conversation();
        bool requirementsFulfilled = true;
        if (topic.leadIns != null)
        {
            for (int i = 0; i < topic.leadIns.Length; i++)
            {

            }
        }
    }

    void AdvanceConversation()
    {
        text.text = currentConversation.lines[convoLineNum];
        if (currentConversation.mugshots[convoLineNum] != null)
        {
            expressions[currentConversation.mugshots[convoLineNum]].SetActive(true);
            if (currentConversation.mugshots[convoLineNum].StartsWith("A_"))
            {
                currentTargetExpression.SetActive(false);
            }
            else
            {
                currentMugshot.SetActive(false);
            }
        }
        if (convoLineNum == currentConversation.pointMadeLine)
        {
            currentConversation.pointMade = true;
            alreadyDiscussed.Add(currentConversation.topic);
        }
        convoLineNum++;
    }

    public void ChangeTopic(string topic)
    {

    }
}
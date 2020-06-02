using System.Collections.Generic;
using UnityEngine;

public class ThoughtSpawner : MonoBehaviour
{
    public GameObject keyword;
    public GameObject gameManagerObj;
    private FormAliGameManager gameManager;
    private List<GameObject> activeThoughts = new List<GameObject>();
    private List<string> topics = new List<string>();
    private float spawnInterval = 4f;
    private float timer = 3f;
    private float speed = 20f;
    private float confessChance = 0.3f;
    private bool stopSpawning = false;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = gameManagerObj.GetComponent<FormAliGameManager>();
        gameManager.Init();
        foreach (string s in gameManager.topics.Keys)
        {
            if (!s.Equals("Confess Fail") && s.IndexOf(" Confession") == -1)
            {
                topics.Add(s);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!stopSpawning)
        {
            timer += Time.deltaTime;
            if (timer > spawnInterval)
            {
                GameObject keywordInst = Instantiate(keyword, gameObject.transform.position + new Vector3(-100, 15), Quaternion.identity, gameObject.transform);
                activeThoughts.Add(keywordInst);
                if (Random.value < confessChance)
                {
                    keywordInst.GetComponent<ButtonScript>().setText("Confess!");
                } else
                {
                    List<int> availableIndices = new List<int>();
                    for (int i = 0; i < topics.Count; i++)
                    {
                        if (!topics[i].Equals(gameManager.currentConversation.topic))
                        {
                            availableIndices.Add(i);
                        }
                    }
                    int index = (int)Mathf.Floor(Random.value * availableIndices.Count);
                    string topic = topics[availableIndices[index]];
                    keywordInst.GetComponent<ButtonScript>().setText(topic);
                }
                timer = 0f;
            }
        }

        GameObject destroyObj = null;
        for (int i = 0; i < activeThoughts.Count; i++)
        {
            activeThoughts[i].transform.position = new Vector3(activeThoughts[i].transform.position.x, activeThoughts[i].transform.position.y + Time.deltaTime * speed);
            if (activeThoughts[i].transform.position.y > gameObject.transform.position.y + 450)
            {
                destroyObj = activeThoughts[i];
            }
        }
        if (destroyObj != null)
        {
            Destroy(destroyObj);
            activeThoughts.Remove(destroyObj);
        }
    }

    public void StopSpawning()
    {
        Refresh();
        stopSpawning = true;
    }

    public void Refresh()
    {
        for (int i = 0; i < activeThoughts.Count; i++)
        {
            Destroy(activeThoughts[i]);
        }
        activeThoughts.Clear();
    }

    public void StartedNewTopic(string topic)
    {
        List<GameObject> destroyedObjs = new List<GameObject>();
        for (int i = 0; i < activeThoughts.Count; i++)
        {
            if (activeThoughts[i].GetComponent<ButtonScript>().topic.Equals(topic))
            {
                destroyedObjs.Add(activeThoughts[i]);
                Destroy(activeThoughts[i]);
            }
        }
        for (int i = 0; i < destroyedObjs.Count; i++)
        {
            activeThoughts.Remove(destroyedObjs[i]);
        }
    }
}

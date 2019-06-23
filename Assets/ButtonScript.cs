using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public GameObject gm;
    private FormAliGameManager manager;
    public GameObject textObj;

    public string topic;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager");
        manager = gm.GetComponent<FormAliGameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickEvent()
    {
        manager.ChangeTopic(topic);
    }

    public void setText(string topic)
    {
        textObj.GetComponent<Text>().text = topic;
        this.topic = topic;
    }
}

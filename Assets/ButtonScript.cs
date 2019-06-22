using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public GameObject gm;
    private FormAliGameManager manager;
    public GameObject textObj;

    // Start is called before the first frame update
    void Start()
    {
        manager = gm.GetComponent<FormAliGameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickEvent()
    {
        manager.ChangeTopic(textObj.GetComponent<Text>().text);
    }
}

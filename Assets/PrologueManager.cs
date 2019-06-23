using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;

public class PrologueManager : MonoBehaviour
{
    public GameObject textObj;
    public AudioSource musicSource;
    public AudioClip musicClip;
    private Text text;
    private string[] lines;
    private int i = 0;
    private int maxLines;

    // Start is called before the first frame update
    void Start()
    {
        musicSource.clip = musicClip;
        musicSource.Play();
        text = textObj.GetComponent<Text>();
        StreamReader reader = new StreamReader("Assets/prologue.json");
        PrologueContainer c = JsonUtility.FromJson<PrologueContainer>(reader.ReadToEnd());
        lines = c.lines;
        maxLines = lines.Length;
        text.text = lines[i];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("space")) {
            i++;
            if (i < maxLines)
            {
                text.text = lines[i];
            }
            else {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}

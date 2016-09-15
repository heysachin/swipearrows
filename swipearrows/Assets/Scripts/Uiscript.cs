using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Uiscript : MonoBehaviour {
    public Text scoreText;
    int score;
    public SoundManager sm;
    public Text txt;

    // Use this for initialization

    void Awake()
    {

    }

	void Start () {
        score = 0;      
       InvokeRepeating("Scoreupdate", 1.0f, 1f);
        
    }
	
	// Update is called once per frame
	void Update () {
        if(scoreText != null)
            scoreText.text = "" + score+"s";
        
    }
    public void Scoreupdate()
    {       
        score = score + 1;
        
    }
    public void Play()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
    public void Pause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            sm.s1.Pause();
        }
            
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            sm.s1.Play();
        }
           
    }
    public void terminate()
    {
        Application.Quit();
    }
    public void menu()
    {
        SceneManager.LoadScene(0);
    }
    public void help()
    {
        SceneManager.LoadScene(3);
    }
    public void gameoverboy()
    {
        string key = "highscore";
        string key1 = "score";
        PlayerPrefs.SetInt(key1, score);
        if (PlayerPrefs.HasKey(key))
        {
            if (PlayerPrefs.GetInt(key) < score)
                PlayerPrefs.SetInt(key, score);
        }

        else
            PlayerPrefs.SetInt(key,score);
        PlayerPrefs.Save();
        Debug.Log("Gameoverboy is good");
        SceneManager.LoadScene(2);
    }
    public void  teXtchange()
    {
        if(SoundManager.audiobool == false)
        {
            txt.text = "SOUND OFF";
            txt.color = Color.red;
        }
        else if (SoundManager.audiobool == true)
        {
            txt.text = "SOUND ON";
            txt.color = Color.green;
        }

    }

    
}

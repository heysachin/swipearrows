using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SCORESET : MonoBehaviour {
    public Text t1;
    public Text t2;
    // Use this for initialization
    void Start () {

        
        t1.text = "Score\n" +PlayerPrefs.GetInt("score")+"s";
        if(PlayerPrefs.GetInt("highscore") == PlayerPrefs.GetInt("score"))
            t2.text = "New High Score\n" + PlayerPrefs.GetInt("score") + "s";
        else
            t2.text = "High Score\n" + PlayerPrefs.GetInt("highscore")+"s";

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}

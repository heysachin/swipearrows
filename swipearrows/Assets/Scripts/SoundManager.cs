using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {
    public AudioSource s1;
    public static bool audiobool;
        // Use this for initialization
    void Start () {
        if (AudioListener.volume > 0.0f)

            audiobool = true;

        else
            audiobool = false;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
   
    public void clicksound()
    {
        
        if (audiobool == false)
        {
            audiobool = true;
            AudioListener.volume = 1.0f;
        }
        else
        {
            audiobool = false;
            AudioListener.volume = 0.0f;
        }

    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class expn : MonoBehaviour {
    public Text txt;
	// Use this for initialization
	void Start () {
        if (AudioListener.volume <= 0)
        {
            txt.text = "SOUND OFF";
            txt.color = Color.red;
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}

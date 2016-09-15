using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Threading;

public class Destroyer : MonoBehaviour {
    public Uiscript ui;
	// Use this for initialization
	void Start () {
       // ui = GetComponent<Uiscript>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter2D(Collision2D col)
    {
        switch (col.gameObject.tag)
        {
            case "movingobjgu": case "movingobjgd": case "movingobjru": case "movingobjrd":
                Destroy(col.gameObject);
                  ui.gameoverboy();
                break;
        }
    }
    void OnApplicationPause(bool booli)
    {
        if (booli)
            Time.timeScale = 0;
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Backpress : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {


            if (Time.timeScale == 0)
                SceneManager.LoadScene(0);
            else if (Time.timeScale == 1)
                Time.timeScale = 0;



        }
    }
}

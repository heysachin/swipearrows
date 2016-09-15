using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CarSpawn2 : MonoBehaviour {
    public GameObject[] obj;
    int objno;
    public float minpos = -3.3f;
    public float maxpos = 3.3f;
    public float delaytimer = 4f;
    public int level1 = 5;
    public int level2 = 5;
    float timer;
    // Use this for initialization
    void Start()
    {
        timer = delaytimer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
       if (timer <= 0)
        {   
            if (level1 >=0)
            {
                Vector3 pos = new Vector3(transform.position.x, Random.Range(minpos, maxpos), 0);
                Instantiate(obj[1], pos, transform.rotation);
                level1--;
                if (level1 == 2) delaytimer = 1.5f;
            }
            else if(level2>=0)
            {
                Vector3 pos = new Vector3(transform.position.x, Random.Range(minpos, maxpos), 0);
                objno = Random.Range(0, 2);
                Instantiate(obj[objno], pos, transform.rotation);
                level2--;
                if(level2 == 2)delaytimer = .9f;
                if (level2 == 0) delaytimer = 1.5f;
            }
            else
            {   
                Vector3 pos = new Vector3(transform.position.x, Random.Range(minpos, maxpos), 0);
                objno = Random.Range(0, 4);
                Instantiate(obj[objno], pos, transform.rotation);
                if (delaytimer > 0.6)
                    delaytimer = delaytimer - (float)0.005;
            }
            timer = delaytimer;
        }
       
    }  
}

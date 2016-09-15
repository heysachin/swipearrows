using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Oppositemov : MonoBehaviour
{
    public float speed = 5f;
    float y,y1;
    Quaternion q;


    // Use this for initialization
    void Start()
    {
        y1 = gameObject.transform.position.y;
        q = transform.rotation;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime);
        transform.rotation = q;
        transform.position = new Vector3(transform.position.x, y1, transform.position.z);
    }
    
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Line") {
            y = LineHandler.touch.position.y - LineHandler.pos0;
            if ((y>0 && (gameObject.tag == "movingobjgu" || gameObject.tag == "movingobjrd")) || (y<0 && (gameObject.tag == "movingobjgd" || gameObject.tag == "movingobjru")))
               // if ((gameObject.transform.position.y > y &&( gameObject.tag == "movingobjgu" || gameObject.tag == "movingobjrd")) || (gameObject.transform.position.y < y && (gameObject.tag == "movingobjgd" || gameObject.tag == "movingobjru")))
              
                {
                Destroy(this.gameObject);
            }
           
        }
    }
}


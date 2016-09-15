using UnityEngine;
using System.Collections;

public class Htran : MonoBehaviour {
    public float speed = 0.5f;
    Vector2 offset;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        offset = new Vector2(speed * Time.time,0);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
	}
}

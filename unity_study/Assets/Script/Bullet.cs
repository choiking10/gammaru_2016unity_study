using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
    public GameObject shooter;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
    void OnTriggerEnter(Collider col)
    {
        if (col.tag.CompareTo("map") == 0)
        {
            Destroy(gameObject);
        }
    }
}

using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
    public GameObject shooter;
    public GameObject explosion;
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
    void Destroy_bullet()
    {
        Destroy(gameObject);
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag.CompareTo("map") == 0)
        {
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            GetComponent<Rigidbody>().useGravity = false;
            GameObject obj = (GameObject)GameObject.Instantiate(explosion, gameObject.transform.position, Quaternion.identity);
            obj.transform.parent = gameObject.transform;

            Invoke("Destroy_bullet", 0.5f);
        }
    }
}

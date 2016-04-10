using UnityEngine;
using System.Collections;

public class MoveInput : MonoBehaviour {
    public Rigidbody mybody;
    public float forcepower;
	// Use this for initialization
	void Start () {
        mybody = gameObject.GetComponent<Rigidbody>();
        forcepower = 10;
	}
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            mybody.AddForce(transform.right * forcepower);
        }
        if (Input.GetKey(KeyCode.A))
        {
            mybody.AddForce(transform.forward * forcepower);
        }
        if (Input.GetKey(KeyCode.S))
        {
            mybody.AddForce(-transform.right * forcepower);
        }
        if (Input.GetKey(KeyCode.D))
        {
            mybody.AddForce(-transform.forward * forcepower);
        }
	}
}

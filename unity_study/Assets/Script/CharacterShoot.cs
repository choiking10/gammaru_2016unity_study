using UnityEngine;
using System.Collections;

public class CharacterShoot : MonoBehaviour {

    public GameObject bulletPrefab;
    public float power;
    public float bef;
    public float delay;
	// Use this for initialization
	void Start () {
        bef = Time.fixedTime;
	}
	
	// Update is called once per frame
	void Update () {

	    if(Input.GetMouseButton(0) && Time.fixedTime - bef > delay){
            bef = Time.fixedTime;
            Vector3 ch = Camera.main.WorldToScreenPoint(gameObject.transform.position);
            Vector3 mouse = Input.mousePosition;
            mouse.z = ch.z;
            Vector3 world_ch = Camera.main.ScreenToWorldPoint(ch);
            Vector3 world_mouse = Camera.main.ScreenToWorldPoint(mouse);
            
            Vector3 dir = Vector3.Normalize(world_mouse-world_ch);
            GameObject bullet = (GameObject)GameObject.Instantiate(bulletPrefab,Vector3.zero,Quaternion.identity);
            bullet.transform.position = gameObject.transform.position;
            dir.y = 0.1f;
            bullet.GetComponent<Rigidbody>().velocity = gameObject.transform.parent.GetComponent<Rigidbody>().velocity + dir * power;
            
        }

	}
}

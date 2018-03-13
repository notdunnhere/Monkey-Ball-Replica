using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.eulerAngles = new Vector3(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y+1.0f, transform.rotation.eulerAngles.z);

    }

    void OnTriggerEnter(Collider other)
    {
        GameObject player = GameObject.Find("Player");
        Movement p = (Movement)player.GetComponent(typeof(Movement));
        p.pickups = p.pickups + 5;
        Destroy(this.gameObject);

    }



}

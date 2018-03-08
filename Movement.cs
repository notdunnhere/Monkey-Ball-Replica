using UnityEngine;

public class Movement : MonoBehaviour {

    public Rigidbody body;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (Input.GetKey("d")) {
            body.AddForce(350 * Time.deltaTime, 0, 0);

        }

        if (Input.GetKey("a"))
        {
            body.AddForce(-350 * Time.deltaTime, 0, 0);

        }

        if (Input.GetKey("w"))
        {
            body.AddForce(0, 0, 350 * Time.deltaTime);

        }

        if (Input.GetKey("s"))
        {
            body.AddForce(0, 0, -350 * Time.deltaTime);

        }

    }
}

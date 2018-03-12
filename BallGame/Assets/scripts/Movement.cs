using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour {

    public Rigidbody body;
    public int pickups = 770;

    public Text score;
    
    public void PickUp()
    {
       
        pickups = pickups + 5;

    }

    int getPickUps()
    {
        return pickups;

    }


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        score.text = pickups.ToString();

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

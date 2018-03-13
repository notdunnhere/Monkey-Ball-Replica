using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour {

    public Rigidbody body;
    public Text score;
    public int pickups = 0;
    public int hits = 0;
    public int totalScore;

    public float jumpSpeed = 5f;
    private float canJump = 0f;
   

    public void PickUp()
    {
        pickups = pickups + 5;

    }

    int getPickUps()
    {
        return pickups;

    }

    public void Hit()
    {
        hits = hits - 1; ;

    }

    int getHits()
    {
        return hits;

    }

    // Use this for initialization
    void Start () {

        score = GameObject.FindGameObjectWithTag("score").GetComponent<Text>(); 


    }
	
	// Update is called once per frame
	void FixedUpdate () {

        totalScore = hits + pickups;

        score.text = totalScore.ToString();
        //print(score.text);

        if (Input.GetKeyDown("space") && Time.time > canJump)
        {
            body.velocity += jumpSpeed * Vector3.up;
            canJump = Time.time + 1f;
        }

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


        if (body.position.y < -16f) {

            FindObjectOfType<GameManager>().EndGame();

        }

    }
}

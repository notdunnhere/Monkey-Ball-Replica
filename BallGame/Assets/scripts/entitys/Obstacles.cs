using UnityEngine;

public class Obstacles : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
   

    }

    void OnCollisionEnter(Collision collision)
    {
        GameObject player = GameObject.Find("Player");
        Movement p = (Movement)player.GetComponent(typeof(Movement));
        p.hits = p.hits - 1;

    }


}

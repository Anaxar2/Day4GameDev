using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScriot : MonoBehaviour
{
    Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;// sets positions of balls
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Catcher") // makes balls return to start position if it hits the catcher bottom.
           
        {transform.position = startPosition;}

        if (other.tag == "Ground") //makes balls return to start position if it hits the ground.

        { transform.position = startPosition;}
    }


}

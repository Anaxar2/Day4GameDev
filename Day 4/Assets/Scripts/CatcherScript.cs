using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatcherScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal"), 0, 0); //moves catcher left and right
    }
}

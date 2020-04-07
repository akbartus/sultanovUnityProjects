using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjects : MonoBehaviour
{
    // pubic is written to make variable public
    // The type of variable should be defined, in this case it is Vector3, which has x,y,z values
    public Vector3 moveSpeed;

    // Start is called before the first frame update
    // Called once
    void Start()
    {

    }

    // Update is called once per frame
    // It is done for repeated things
    // Translate is move
    void Update()
    {
        transform.Translate(Vector3.left);
        transform.Translate(moveSpeed);


    }
}

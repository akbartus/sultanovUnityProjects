using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class agentMover : MonoBehaviour
{   
    [Header("Navigation Components")] // Giving title inside of the component
    public NavMeshAgent agent;
    public Transform moveTarget;
    public float defaultMoveSpeed = 10;
    public bool doMoveAtDoubleSpeed;

    void DoubleNumber() 
    {
        
    }
    /*
    
    public int myInteger = 056;
    public float myFloat = -3.445;
    public string myString = "Example";
    */

    //public Collider agent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // delta time
        // Time.deltaTime
        agent.SetDestination(moveTarget.position);
        if (doMoveAtDoubleSpeed == true)
        {
            //agent.speed = 10;
            agent.speed = defaultMoveSpeed;
        }
        else
        {
            //agent.speed = 5;
            agent.speed = defaultMoveSpeed;
}
    }
}

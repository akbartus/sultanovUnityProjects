using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIMotor : MonoBehaviour
{
    public NavMeshAgent agent;
    
    public Transform moveMyTarget;
    public float defaultMoveSpeed = 10;
    public bool slowlyReduceSpeed;
 

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
        agent.SetDestination(moveMyTarget.position);
        if (slowlyReduceSpeed == true)
        {
            //agent.speed = 10;
            agent.speed -= 0.05f;

        }
        else
        {
            //agent.speed = 5;
            agent.speed = defaultMoveSpeed;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class UnitPlayer1 : MonoBehaviour
{
    public GameObject Target;
   

    void Start()
    {
        
        Target = GameObject.FindGameObjectWithTag("UnitPlayer2");


    }
     void Update()
    {

        if (Target)
        {
            Vector3 destination = new Vector3(Target.transform.position.x, 0, Target.transform.position.z);
            GetComponent<NavMeshAgent>().destination = destination;
        }
    }



}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class UnitPlayer2 : MonoBehaviour
{
    
        void Update()
        {
        // Targets = ;
           GameObject Target = GameObject.FindWithTag("UnitPlayer1");
            if (Target)
            {
                Vector3 destination = new Vector3(Target.transform.position.x, 0, Target.transform.position.z);
                GetComponent<NavMeshAgent>().destination = destination;
            }
        }

        

    }
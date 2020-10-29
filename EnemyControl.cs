using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



// This script utilizes unity's AI library to have a mixamo character either follow a target GameOject 
//or to follow a patrol route made of up empty gameobjects

// Give this to enemy character
public class EnemyControl : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator control;
    public GameObject target;

    private NavMeshAgent agent;
    public Transform route;
    public List<Transform> locations;
    private int locationIndex = 0;
    

    void Start()
    {
        control = this.GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();

        control.SetInteger("state",1);

        InitializePatrolRoute();
        MoveToNextLocation();

     
    }

    // Update is called once per frame


    

    void Update()
    {
      /*  follow a patrol route
        if (agent.remainingDistance<0.2f && !agent.pathPending){
            StartCoroutine(wait(2.0f));
            MoveToNextLocation();
        }
        */
        followPlayer();
        
    }


    private IEnumerator wait(float waitTime)
    {
      
            yield return new WaitForSeconds(waitTime);
    }



    void followPlayer(){
        agent.destination = target.transform.position;
    }

    void InitializePatrolRoute(){
        foreach(Transform child in route){
            locations.Add(child);
        }
    }
    void MoveToNextLocation(){
        if (locations.Count == 0){
            return;
        }
        agent.destination = locations[locationIndex].position;
        locationIndex = (locationIndex+1)%locations.Count;
    }

}

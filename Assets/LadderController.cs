using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;

public class LadderController : MonoBehaviour
{
    NavMeshLink navMeshLink;
    // Start is called before the first frame update
    void Start()
    {
        navMeshLink = GetComponent<NavMeshLink>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        //Debug.Log("Ladder Collision");
        //if(other.gameObject.tag == "Player")
        //{
        //    other.gameObject.GetComponent<NavMeshAgent>().Warp(navMeshLink.endPoint);
        //}
    }
}

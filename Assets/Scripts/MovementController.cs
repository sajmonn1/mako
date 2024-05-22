using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using Unity.AI.Navigation;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class MovementController : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var cursorPosition = CursorWorldPosition();
        //if cursor is pointing at something
        if(cursorPosition != null)
        {
            //get direction pointing at the cursor
            Vector3 direction = (Vector3)cursorPosition - transform.position;
            //rotate the player to face the cursor
            Quaternion rotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Lerp(transform.rotation, rotation, 10 * Time.deltaTime);
        }
        
    }
    public void MovePlayerTo(Vector3 targetPosition)
    {
        gameObject.GetComponent<NavMeshAgent>().SetDestination(targetPosition);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ladder")
        {
            Debug.Log("Ladder Collision");
            
        }
    }
    Vector3? CursorWorldPosition()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit))
        {
            //point of ray impact
            Vector3 cursorPosition = hit.point;
            //corecting the y position of the cursor to match the player base so the light doesnt go up and down
            cursorPosition.y = transform.position.y;
            //return corrected cursor position
            return cursorPosition;
        }
        else
        {
            //cursor is not pointing at anything, return null
            return null;
        }
    }
}

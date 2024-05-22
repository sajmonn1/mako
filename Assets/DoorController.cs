using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    GameObject hinge;
    [SerializeField]
    bool isOpen = false;
    bool playerInRange = false;
    // Start is called before the first frame update
    void Start()
    {
        hinge = transform.Find("Hinge").gameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OpenDoor()
    {
        if (playerInRange)
        {
            hinge.transform.Rotate(0, 90, 0);
            isOpen = true;
        }
    }
    void CloseDoor()
    {
        if (playerInRange)
        {
            hinge.transform.Rotate(0, -90, 0);
            isOpen = false;
        }

    }
    private void OnMouseDown()
    {
        CheckIfPlayerInRange();

        if (isOpen)
        {
            CloseDoor();
        }
        else
        {
            OpenDoor();
        }
    }
    private void CheckIfPlayerInRange()
    {
        float distance = Vector3.Distance(transform.position, GameObject.FindGameObjectWithTag("Player").transform.position);
        if (distance < 2)
        {
            playerInRange = true;
        }
        else
        {
            playerInRange = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileController : MonoBehaviour
{
    //player movement controller
    MovementController movementController;
    GameObject mouseOver;
    [SerializeField]
    private bool isInteractable;
    // Start is called before the first frame update
    void Start()
    {
        //overlay showing mouse over
        mouseOver = transform.Find("MouseOver").gameObject;
        //player movement controller
        movementController = GameObject.FindWithTag("Player").GetComponent<MovementController>();
        //random rotation of tiles
        transform.Find("FloorModel").localRotation = Quaternion.Euler(-90, 0, Random.Range(0, 4) * 90);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseEnter()
    {
        //mouse over the tile
        if(isInteractable)
        {
            //only show mouse over if the tile is interactable
            mouseOver.SetActive(true);
        }
        
        //Debug.Log("Mouse Over");
    }
    private void OnMouseDown()
    {
        //mouse click on the tile
        if(isInteractable)
        {
            //only move player if the tile is interactable
            movementController.MovePlayerTo(transform.position);
        }
        
       
    }
    private void OnMouseExit()
    {
        //mouse exit the tile
        mouseOver.SetActive(false);
    }
}

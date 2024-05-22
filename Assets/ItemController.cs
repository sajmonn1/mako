using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    GameObject mouseOverlay;
    // Start is called before the first frame update
    void Start()
    {
        mouseOverlay = transform.Find("MouseOverlay").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseEnter()
    {
        mouseOverlay.SetActive(true);
    }
    private void OnMouseExit()
    {
        mouseOverlay.SetActive(false);
    }
}

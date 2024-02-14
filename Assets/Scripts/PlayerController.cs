using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += new Vector3(1, 0, 0) * Time.deltaTime;
        float x = Input.GetAxis("Horizontal");
        Debug.Log(x);

        Vector3 movement = Vector3.right * x;

        float y = Input.GetAxis("Vertical");
        movement += Vector3.forward * y;
        movement = movement.normalized;
        movement *= Time.deltaTime;
        movement *= moveSpeed;
        transform.position += movement;
    }
}

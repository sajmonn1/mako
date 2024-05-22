using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // pozycja gracza
    Transform player;
    // offset kamery
    Vector3 cameraOffset;
    //pr�dko�� przesuwania kamery - nie nadajemy warto�ci - zrobi to smoothDamp
    Vector3 cameraSpeed;
    //czas wyg�adzania ruchu kamery
    float smoothTime = 0.3f;
    //docelowa ilo�� klatek na sekund�
    public int targetFrameRate = 60;

    // Start is called before the first frame update
    void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = targetFrameRate;
        // znajdz gracza i pod��cz jego pozycj� do zmiennej transform
        player = GameObject.FindGameObjectWithTag("Player").transform;
        // pobierz domy�lny offset kamery
        cameraOffset = transform.position - player.position;
    }

    // Update is called once per frame
    void Update()
    {
        //pozycja kamery to pozyja gracza + offset
        //transform.position = player.position + cameraOffset;



        //bardziej kulturalnie - lerp
        //policz pozycje docelow�
        Vector3 targetPosition = player.position + cameraOffset;
        
        //u�yj interpolacji liniowej
        //transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime);
        
        //u�yj smooothdamp
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref cameraSpeed, smoothTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    //czas do zakonczenia poziomu
    public float timeLeft = 90f;

    //elementy UI
    public GameObject timeCounter;
    public GameObject gameOverOverlay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //zmniejsz ilosc czasu pozosta³ego na wykonanie poziomu
        //o czas, który min¹³ od ostaniej klatki
        timeLeft -= Time.deltaTime;



        //aktualizuj UI
        UpdateUI();
    }

    void UpdateUI()
    {
        //funkcja odpowiedzialna za aktualizacjê interfejsu u¿ytkownika

        timeCounter.GetComponent<TextMeshProUGUI>().text = "Pozosta³y czas:" + Mathf.Floor(timeLeft).ToString();

        //jeœli czas siê skoñczy³
        if(timeLeft <= 0)
            gameOverOverlay.SetActive(true);
    }
    public void OnWin()
    {
        //ta funkcja jest wywo³ywana jeœli wygramy (np dojdziemy do konca poziomu)
        gameOverOverlay.SetActive(true);
        gameOverOverlay.transform.Find("ReasonText").GetComponent<TextMeshProUGUI>().text = "Wygra³eœ!";

    }
    public void OnLose()
    {
        //ta fukcja jest wywo³ywana przy pora¿ce
        gameOverOverlay.SetActive(true);
        gameOverOverlay.transform.Find("ReasonText").GetComponent<TextMeshProUGUI>().text = "Kamera ciê zobaczy³a!";
    }
}

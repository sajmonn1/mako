using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;

public class VisibilityController : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> levelGeometry;
    private GameObject player;
    [SerializeField]
    private float visibilityRange = 4f;
    // Start is called before the first frame update
    void Start()
    {
        levelGeometry = new List<GameObject>();
        foreach (Transform t in transform)
        {
            levelGeometry.Add(t.gameObject);
        }
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

        foreach (GameObject obj in levelGeometry)
        {
            if (obj.transform.position.y > player.transform.position.y+2)
            {
                obj.SetActive(false);
            }
            else
            {
                obj.SetActive(true);
            }
        }
    }
}

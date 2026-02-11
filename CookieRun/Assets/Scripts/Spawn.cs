using System.Collections;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;


public class Spawn : MonoBehaviour
{
    public GameObject[] Obstacle;
    public int number;

    float timer;
    int waitingTime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = 0;
        waitingTime = 2;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > waitingTime)
        {
            number = Random.Range(0, Obstacle.Length);
            timer = 0;
            Destroy(Instantiate(Obstacle[number], transform.position, transform.rotation), 5f);
        }
    }
}

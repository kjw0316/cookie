using UnityEditor;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float move = 1.0f;

    public int blood = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(- Time.deltaTime * move, 0, 0);
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            blood -= 1;
        }
    }
}

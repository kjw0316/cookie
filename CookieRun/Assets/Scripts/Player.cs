using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpHeight = 1.3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            transform.Translate(0, jumpHeight, 0);

            if (Input.GetKeyUp(KeyCode.Space)){
                transform.Translate(0, jumpHeight, 0);
            }
            else
            {
                transform.Translate(0, 0, 0);
            }
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.localScale = new Vector3(1, 0.1f, 1);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            Debug.Log("Landed on the ground");
        }
    }
}


using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
public class Player : MonoBehaviour
{
    public float jumpHeight = 2f;

    public TextMeshProUGUI bloodText;
    public int blood = 5;

    public GameObject Image;
    public GameObject Button;

    public int count = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Image.gameObject.SetActive(false);
        Button.gameObject.SetActive(false);

        Length.playing = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            transform.Translate(0, jumpHeight , 0);
            count++;
            if (count > 2)
            {
                transform.Translate(0, -jumpHeight , 0);
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

        bloodText.text = "Blood : " + blood;

        if (blood <= 0)
        {
            Image.gameObject.SetActive(true);
            Button.gameObject.SetActive(true);
            Length.playing = false;
        }
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            blood -= 1;
            Debug.Log("ddddd");
        }
        if (other.gameObject.tag == "Plane")
        {
            count = 0;
        }
    }

}

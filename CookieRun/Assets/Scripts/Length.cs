using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Length : MonoBehaviour
{
    public float lengthInMeters;
    public TextMeshProUGUI lengthText;

    public GameObject Image;
    public GameObject Button;

    public static bool playing;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Image.gameObject.SetActive(false);
        Button.gameObject.SetActive(false);

        playing = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (playing)
        {
            lengthInMeters += Time.deltaTime * 10;
            lengthText.text = "Length : " + Mathf.FloorToInt(lengthInMeters) + "m";
        }

        if (lengthInMeters >= 100)
        {
            playing = false;
            Image.gameObject.SetActive(true);
            Button.gameObject.SetActive(true);
        }
    }
}

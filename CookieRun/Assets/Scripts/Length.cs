using UnityEngine;
using TMPro;

public class Length : MonoBehaviour
{
    public float lengthInMeters;
    public TextMeshProUGUI lengthText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lengthInMeters += Time.deltaTime * 10;
        lengthText.text = "Length : " + Mathf.FloorToInt(lengthInMeters) + "m";
    }
}

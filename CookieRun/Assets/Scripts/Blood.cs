using UnityEngine;
using TMPro;

public class Blood : Obstacle
{
    public TextMeshProUGUI bloodText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bloodText.text = "Blood : " + blood;
    }
}

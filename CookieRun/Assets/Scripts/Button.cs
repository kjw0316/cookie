using UnityEngine;
using TMPro;
using Unity.VectorGraphics;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnStartClick()
    {
        SceneManager.LoadScene("Game");
    }
    public void OnEndingClick()
    {
        SceneManager.LoadScene("Title");
    }

}

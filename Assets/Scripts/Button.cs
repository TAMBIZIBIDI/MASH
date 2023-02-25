using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RetryGame()
    {
        SceneManager.LoadScene("Game"); //Change???
    }

    public void QuitApplication()
    {
        Application.Quit();
    }
}

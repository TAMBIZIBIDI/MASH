using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int soldiersInField;
    bool crashed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(soldiersInField == 0)
        {
            SceneManager.LoadScene("YouWin");
        }
        else if(crashed)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}

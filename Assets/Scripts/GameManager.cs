using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int soldiersInField;
    bool crashed;

    // Start is called before the first frame update
    void Start()
    {
        soldiersInField = GameObject.FindGameObjectsWithTag("Soldier").Length;
        Debug.Log(soldiersInField);
    }

    // Update is called once per frame
    void Update()
    {
        if(soldiersInField == 0)
        {
            Debug.Log("You win");
            SceneManager.LoadScene("YouWin");
        }
        else if(crashed)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}

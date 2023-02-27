using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text heliScore;
    public Text rescuedScore;

    void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateHeliScore(string soldiersInHeli)
    {
        heliScore.text = soldiersInHeli;
    }

    public void UpdateRescuedScore(string rescuedSoldiers)
    {
        rescuedScore.text = rescuedSoldiers;
    }
}

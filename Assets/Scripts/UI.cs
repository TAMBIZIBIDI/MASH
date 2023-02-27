using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text heliTxt;
    public Text rescuedTxt;

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
        heliTxt.text = "Soldiers in Helicopter: " + soldiersInHeli;
    }

    public void UpdateRescuedScore(string rescuedSoldiers)
    {
        rescuedTxt.text = "Soldiers Rescued: " + rescuedSoldiers;
    }
}

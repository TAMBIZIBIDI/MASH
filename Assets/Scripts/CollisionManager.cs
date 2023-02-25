using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    int heliSoldierCount = 0;
    int maxSoldierCount = 3;
    int soldiersRescued = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "Tree":
                UnityEditor.EditorApplication.isPlaying = false;
                //Add a way to go to a new scene (with UI) stating they lost etc...
                break;
            case "Soldier":
                ManagerSoldierCount(other);
                break;
            case "MedTent":
                MedicalTent();
                break;
            default:
                break;
        }
    }

    void ManagerSoldierCount(Collider other)
    {
        if (heliSoldierCount < maxSoldierCount)
        {
            Destroy(other.gameObject);
            heliSoldierCount++;
            Debug.Log("Helicopter: " + heliSoldierCount);
        }
        else
        {
            ;
        }
    }

    private void MedicalTent()
    {
        if (heliSoldierCount != 0)
        {
            soldiersRescued = soldiersRescued + heliSoldierCount;
            heliSoldierCount = 0;

            Debug.Log("MedicalTent: " + soldiersRescued);
            Debug.Log("Helicopter: " + heliSoldierCount);
        }
        else
        {
            ;
        }
    }
}

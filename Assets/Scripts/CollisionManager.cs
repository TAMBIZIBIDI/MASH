using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    int soldierCount = 0;
    int maxSoldierCount = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch(collision.gameObject.tag)
        {
            case "Tree":
                UnityEditor.EditorApplication.isPlaying = false;
                //Add a way to go to a new scene (with UI) stating they lost etc...
                break;
            case "Soldier":
                ManagerSoldierCount(collision);
                break;
            case "MedTent":

                break;
            default:
                break;
        }
    }

    private void ManagerSoldierCount(Collision collision)
    {
        if (soldierCount < maxSoldierCount)
        {
            Destroy(collision.gameObject);
            soldierCount++;
        }
        else
        {
            ;
        }
    }
}

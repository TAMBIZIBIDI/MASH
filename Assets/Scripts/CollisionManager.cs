using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionManager : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;

    public GameManager gm;

    int heliSoldierCount = 0;
    int maxSoldierCount = 3;
    int soldiersRescued = 0;

    public UI uiClass;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        uiClass.UpdateHeliScore(heliSoldierCount.ToString());
        uiClass.UpdateRescuedScore(soldiersRescued.ToString());
    }

    void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "Tree":
                SceneManager.LoadScene("GameOver");
                break;
            case "Shell":
                SceneManager.LoadScene("GameOver");
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
            audioSource.Play();
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
            gm.soldiersInField = gm.soldiersInField - heliSoldierCount;
            Debug.Log(gm.soldiersInField);
            heliSoldierCount = 0;
        }
        else
        {
            ;
        }
    }
}

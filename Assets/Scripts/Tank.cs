using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] float tankMoveSpeed;
    [SerializeField] GameObject shell;
    [SerializeField] float rateOfFire;

    float fireTime = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(player.transform.position.x, transform.position.y, transform.position.z), Time.deltaTime * tankMoveSpeed);

        if (Time.time > fireTime)
        {
            fireTime += rateOfFire;
            Instantiate(shell, transform.position, shell.transform.rotation);
        }
    }
}

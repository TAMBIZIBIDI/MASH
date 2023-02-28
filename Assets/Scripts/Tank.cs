using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] float tankMoveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(player.transform.position.x, transform.position.y, transform.position.z), Time.deltaTime * tankMoveSpeed);
        //transform.Translate((player.transform.position.x * Time.deltaTime * tankMoveSpeed), 0, 0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float movementSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed;
        float moveY = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed; 
        //moveZ

        transform.Translate(moveX, moveY, 0);
    }
}

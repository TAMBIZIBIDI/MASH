using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float movementSpeed = 5.0f;

    Rigidbody rg;
    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            rg.AddRelativeForce(Vector3.up * Time.deltaTime * movementSpeed);
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            rg.AddRelativeForce(Vector3.down * Time.deltaTime * movementSpeed);
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rg.AddRelativeForce(Vector3.right * Time.deltaTime * movementSpeed);
            //transform.localRotation = Quaternion.Euler(0, 180, 0); //???
            sr.flipX = true;
            
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rg.AddRelativeForce(Vector3.left * Time.deltaTime * movementSpeed);
            //transform.localRotation = Quaternion.Euler(0, 0, 0);
            sr.flipX = false;
        }
        else
        {
            rg.velocity = Vector3.zero;
        }

        /*
        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed;
        float moveY = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;
        //moveZ

        transform.Translate(moveX, moveY, 0);

        Debug.Log(moveX);
        
        if(moveX > -0.1f)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        */
    }
}

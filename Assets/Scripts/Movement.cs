using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        if(Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("Game");
        }

        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed;
        float moveY = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;

        transform.Translate(moveX, moveY, 0);

        FlipSprite();
    }

    private void FlipSprite()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            sr.flipX = true;
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            sr.flipX = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
   public float moveSpeed = 8.65f;
    public float runSpeed = 12f;
    public float walkSpeed = 8.65f;
    public float jumpForce = 12f;
    public int jumpLimit = 2;
    int jumpCount;
    Vector3 moveDirection;

    Rigidbody rb;

    bool isGrounded = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jumpCount = jumpLimit;
}

    // Update is called once per frame
    void Update()
    {
        moveDirection = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            moveDirection += Vector3.forward;
        }

        if (Input.GetKey(KeyCode.A))
        {
            moveDirection += Vector3.left;
        }

        if (Input.GetKey(KeyCode.S))
        {
            moveDirection += Vector3.back;
        }

        if (Input.GetKey(KeyCode.D))
        {
            moveDirection += Vector3.right;
        }

        if (Input.GetKey(KeyCode.R))
        {
            moveSpeed = runSpeed;
        }
        else
        {
            moveSpeed = walkSpeed;
        } 

        moveDirection.Normalize();

        if(Input.GetKeyDown(KeyCode.Space) && jumpCount >0)

        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;

            jumpCount = jumpCount - 1;
        }

        
            
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            jumpCount = jumpLimit;
        }
    }

    void FixedUpdate()
    {
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }

}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownBasicMovment : MonoBehaviour
{
    float moveSpeed = 3;
    float Originaly;
    bool movingUp = false;
    
    // Start is called before the first frame update
    void Start()
    {
        Originaly = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {

        //Vector3 newRotation = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + 180.0f,
        //transform.eulerAngles.z);
        if (transform.position.y >= Originaly + 10.0f)
        {
            movingUp = false;
        }
        else if (transform.position.y <= Originaly - 10.0f)
        {
            movingUp = true;
        }

        if (movingUp == false)
        {
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }
    }
}

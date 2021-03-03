using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovment : MonoBehaviour
{
    float moveSpeed = 3;
    float Originalz;

    // Start is called before the first frame update
    void Start()
    {
        Originalz = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        Vector3 newRotation = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + 180.0f,
            transform.eulerAngles.z);
        if (transform.position.z >= Originalz + 10.0f)
        {
            transform.rotation = Quaternion.Euler(newRotation);
        }
        else if(transform.position.z <= Originalz - 10.0f)
        {
            transform.rotation = Quaternion.Euler(newRotation);
        }
    }
}

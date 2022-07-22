using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    Rigidbody rB;
    int track = 2;
    public float speed;
    float horizontal;
    public float inputBufferSet;
    float inputBuffer;
    public float jumpSpeed;
    void Start()
    {
        rB = GetComponent<Rigidbody>();
        rB.freezeRotation = true;
    }
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        inputBuffer -= Time.deltaTime;

    }
    void FixedUpdate()
    {
        if (inputBuffer < 0)
        {
            track = sideMovevet(horizontal, track);
        }

        if (horizontal != 0)
        {
            inputBuffer = inputBufferSet;
        }

        if (Input.GetButton("Jump"))
        {

        }

        //rB.velocity = new Vector3(0, 0, speed);
        rB.AddForce(new Vector3(0, jumpSpeed));
    }
    int sideMovevet(float horizontal, int track)
    {
        switch (horizontal)
        {
            case -1:
                if (track != 1)
                {

                    transform.position = new Vector3(transform.position.x - 1.5f, transform.position.y, transform.position.z);
                    track--;
                }
                break;
            case 1:
                if (track != 3)
                {

                    transform.position = new Vector3(transform.position.x + 1.5f, transform.position.y, transform.position.z);
                    track++;
                }
                break;
        }
        //Debug.Log($"input{horizontal}");
        //Debug.Log($"track{track}");
        return track;
    }
}





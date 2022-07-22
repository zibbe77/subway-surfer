using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dieplz : MonoBehaviour
{
    Transform playerL;
    void FixedUpdate()
    {
        playerL = GameObject.Find("Player").GetComponent<Transform>();

        if (this.transform.position.z - playerL.transform.position.z < -20f)
        {
            Destroy(this.gameObject);
            print("Destroy");
        }

    }
}

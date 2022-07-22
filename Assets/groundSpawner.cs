using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundSpawner : MonoBehaviour
{
    float pos = 40;
    float groundPos = 105;
    public GameObject groundPrefab;
    void Update()
    {
        if (this.transform.position.z >= pos)
        {
            for (int i = 0; i < 3; i++)
            {
                GameObject g = Instantiate(groundPrefab) as GameObject;
                g.transform.position = new Vector3(g.transform.position.x, g.transform.position.y, groundPos);
                pos += 30;
                groundPos += 30;
            }
        }
    }
}

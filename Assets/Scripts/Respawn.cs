using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    Vector3 Pos;

    // Update is called once per frame
    void Update()
    {
        Pos = transform.position;
        if (Pos.y < -230)
        {
            transform.position = new Vector3(7.5f, 1.97f, 2.6f);
        }
    }
}

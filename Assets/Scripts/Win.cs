using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    public GameObject message;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        message.SetActive(true);

    }


}

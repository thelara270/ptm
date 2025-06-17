using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uwu : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "enemy")
        {
            other.gameObject.SetActive(false);
        }
        else
        {
            Destroy(other.gameObject);
        }
    }
}

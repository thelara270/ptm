using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class code1 : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bala")
        {
            other.gameObject.SetActive(false);
        }
        else
        {
            Destroy(other.gameObject);
        }
    }

}

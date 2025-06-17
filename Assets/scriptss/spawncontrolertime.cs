using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawncontrolertime : MonoBehaviour
{
    //controla la activación secuencial de varios puntos de aparición
    [SerializeField] GameObject spawn1;
    [SerializeField] GameObject spawn2;
    [SerializeField] GameObject spawn3;
    [SerializeField] GameObject spawn4;
    [SerializeField] GameObject spawn5;
    [SerializeField] GameObject spawn6;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(firstspawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator firstspawn()
    {
        spawn1.gameObject.SetActive(true);

        yield return new WaitForSeconds(2f);

        spawn2.gameObject.SetActive(true);

        yield return new WaitForSeconds(1f);

        spawn3.gameObject.SetActive(true);

        yield return new WaitForSeconds(3f);

        spawn4.gameObject.SetActive(true);

        yield return new WaitForSeconds(4f);

        spawn4.gameObject.SetActive(true);

        yield return new WaitForSeconds(2f);

        spawn5.gameObject.SetActive(true);

        yield return new WaitForSeconds(5f);

        spawn6.gameObject.SetActive(true);

    }
}

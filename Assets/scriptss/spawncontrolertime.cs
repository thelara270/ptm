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
    [SerializeField] GameObject spawn7;
    [SerializeField] GameObject spawn8;
    [SerializeField] GameObject spawn9;
    [SerializeField] GameObject spawn10;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(firstspawn());
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

        yield return new WaitForSeconds(10f);

        spawn6.gameObject.SetActive(true);

        yield return new WaitForSeconds(6f);

        spawn7.gameObject.SetActive(true);

        yield return new WaitForSeconds(4f);

        spawn8.gameObject.SetActive(true);

        yield return new WaitForSeconds(2f);

        spawn9.gameObject.SetActive(true);

        yield return new WaitForSeconds(6f);

        spawn10.gameObject.SetActive(true);

        yield return new WaitForSeconds(8f);

    }
}

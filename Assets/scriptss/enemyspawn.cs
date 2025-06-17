using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class enemyspawn : MonoBehaviour
{
    //se encarga de generar enemigos de forma continua en un punto específico del juego
    [SerializeField] float time;
    [SerializeField] Transform controller;
    
    // Start is called before the first frame update
    void Start()
    {
        //crear();
        spawn();
    }


    // Update is called once per frame
    void Update()
    {

    }

    public void spawn()
    {
        GameObject enemyb = enemypoll.Instance.requestenemy();
        enemyb.transform.position = controller.position;
        enemyb.transform.rotation = controller.rotation;
        Invoke("spawn", time);
    }
}

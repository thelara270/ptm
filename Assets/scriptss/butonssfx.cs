using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class butonssfx : MonoBehaviour
    //reproduce el sonido cuando le das al boton
{
    audiomanagerc audiomanager;

    private void Awake()
    {
        audiomanager = GameObject.FindGameObjectWithTag("audio").GetComponent<audiomanagerc>();
    }
    
   
    public void selct()
    {
        audiomanager.playSFX(audiomanager.butonselect);
    }
}

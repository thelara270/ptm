using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menucontroller : MonoBehaviour
{
    //controla todas las funciones principales del menú del juego, como pausar, reanudar, cambiar de escena, mostrar opciones de música, reiniciar el nivel, y salir del juego
    [SerializeField] Animator fade;
    audiomanagerc audiomanager;
    [SerializeField] AnimationClip fadeout;
    
    private void Awake()
    {
        audiomanager = GameObject.FindGameObjectWithTag("audio").GetComponent<audiomanagerc>();
    }
    public void pause()
    {
        Time.timeScale = 0f;
        audiomanager.sfxsource.Pause();
    }

    public void music(GameObject panel)
    {
        if (panel.activeSelf == false)
        {
            panel.SetActive(true);
        }
        else
        {
            panel.SetActive(false);
        }
    }

    public void unpause()
    {
        Time.timeScale = 1.0f;
        audiomanager.sfxsource.UnPause();
    }
  

    public void reload()
    {
        StartCoroutine(reloadscene());
    }
    IEnumerator reloadscene()
    {
        fade.SetTrigger("fadeout");
        yield return new WaitForSeconds(fadeout.length);
        SceneManager.LoadScene(1);
    }

    public void mainmenu()
    {
        Time.timeScale = 1f;
        Debug.Log("esta vaina sirve");
        StartCoroutine(scenemenu());
    }
    IEnumerator scenemenu()
    {
        Time.timeScale=1.0f;
        fade.SetTrigger("fadeout");

        yield return new WaitForSeconds(fadeout.length);
        SceneManager.LoadScene(0);
    }

    public void Intro()
    {
        Time.timeScale = 1f;
        Debug.Log("esta vaina sirve");
        StartCoroutine(sceneIntro());
    }
    IEnumerator sceneIntro()
    {
        Time.timeScale = 1.0f;
        fade.SetTrigger("fadeout");

        yield return new WaitForSeconds(fadeout.length);
        SceneManager.LoadScene(1);
    }

    public void sceneload()
    {
        StartCoroutine(scenestrasicion());
    }
    IEnumerator scenestrasicion()
    {
        Time.timeScale = 1f;
        audiomanager.playSFX(audiomanager.play);
        fade.SetTrigger("fadeout");
        
        yield return new WaitForSeconds(fadeout.length);
        SceneManager.LoadScene(2);
    }
    public void exit()
    {
        Application.Quit();
    }
}

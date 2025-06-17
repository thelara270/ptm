using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class uijuegocontroller : MonoBehaviour
{
    //controla la interfaz del juego relacionada con pausar, reanudar, reiniciar la escena, volver al menú y mostrar paneles
    [SerializeField] Animator fade;
    audiomanagerc audiomanager;
    [SerializeField] AnimationClip fadeout;
    [SerializeField] GameObject panelp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void pause()
    {
        panelp.SetActive(true);
        Time.timeScale = 0.01f;
    }

    public void unpause()
    {
        panelp.SetActive(false);
        Time.timeScale = 1.0f;
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
        StartCoroutine(scenemenu());
    }
    IEnumerator scenemenu()
    {
        fade.SetTrigger("fadeout");

        yield return new WaitForSeconds(fadeout.length);
        SceneManager.LoadScene(0);
    }
}

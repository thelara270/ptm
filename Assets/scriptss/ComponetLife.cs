using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class ComponetLife : MonoBehaviour
{
    [SerializeField] float heal;

    [SerializeField] Image barravida;
    [SerializeField] float vidamaxima;
    [SerializeField] float vidaactural;
    [SerializeField] GameObject die;

    [SerializeField] Renderer cuerpoJugadorP;
    [SerializeField] Renderer cuerpoJugadorF;
    [SerializeField] Renderer cuerpoJugadorM;
    [SerializeField] Renderer cuerpoJugadorD;
    [SerializeField] Color colorDa�o = Color.red;
    [SerializeField] float tiempoColor = 0.2f;

    [SerializeField] GameObject jugadores;

    private Color colorOriginal;

    audiomanagerc audimager;

    private void Awake()
    {
        audimager = GameObject.FindGameObjectWithTag("audio").GetComponent<audiomanagerc>();
    }
    private void Start()
    {
        colorOriginal = cuerpoJugadorP.material.color;
        colorOriginal = cuerpoJugadorF.material.color;
        colorOriginal = cuerpoJugadorM.material.color;
        colorOriginal = cuerpoJugadorD.material.color;

        vidamaxima = 100f;
    }

    private void Update()
    {
        vidaactural = heal;

        barravida.fillAmount = vidaactural / vidamaxima;
    }

    public void damagerecibe(float damage)
    {
        heal -= damage;
        StartCoroutine(CambiarColorTemporal());
        if (heal <= 0)
        {
            die.SetActive(true);
            audimager.sfxsource.Pause();
            audimager.sfxsource.volume = 0f;
            audimager.musicsource.Pause();
            jugadores.SetActive(false);
        }
    }

    IEnumerator CambiarColorTemporal()
    {
        cuerpoJugadorP.material.color = colorDa�o;
        cuerpoJugadorF.material.color = colorDa�o;
        cuerpoJugadorM.material.color = colorDa�o;
        cuerpoJugadorD.material.color = colorDa�o;

        yield return new WaitForSeconds(tiempoColor);
        cuerpoJugadorP.material.color = colorOriginal;
        cuerpoJugadorF.material.color = colorOriginal;
        cuerpoJugadorM.material.color = colorOriginal;
        cuerpoJugadorD.material.color = colorOriginal;

    }
}

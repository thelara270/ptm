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

    audiomanagerc audimager;

    private void Awake()
    {
        audimager = GameObject.FindGameObjectWithTag("audio").GetComponent<audiomanagerc>();
    }
    private void Start()
    {
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
        if (heal <= 0)
        {
            die.SetActive(true);
            audimager.sfxsource.Pause();
            audimager.sfxsource.volume = 0f;
            audimager.musicsource.Pause();

        }
    }
}

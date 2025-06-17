using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class player_movement : MonoBehaviour
{
    //vida, rotación y muerte del jugador
    [SerializeField] float _rotationTime;
    [SerializeField] Camera _camera;
    //[SerializeField] float heal;
    [SerializeField] Transform cross;
    //[SerializeField] Image barravida;
    //[SerializeField] float vidamaxima;
    //[SerializeField] float vidaactural;
    //[SerializeField] GameObject die;
    audiomanagerc audimager;

    private void Awake()
    {
        audimager = GameObject.FindGameObjectWithTag("audio").GetComponent<audiomanagerc>();
    }
    private void Start()
    {
       
        Time.timeScale = 1.0f;
        //vidamaxima = 100f;
        gameObject.SetActive(true);
    }
    void Update()
    {
        //vidaactural = heal;

        //barravida.fillAmount = vidaactural / vidamaxima;
        Vector3 direccion = cross.position - transform.position;
        direccion.y = 0f; // Ignoramos la componente Y

        if (direccion.sqrMagnitude > 0.001f) // evitar errores con vectores pequeños
        {
            float anguloY = Mathf.Atan2(direccion.x, direccion.z) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, anguloY, 0f);
        }

        //Ray _rayo= _camera.ScreenPointToRay(Input.mousePosition);
        //RaycastHit _informacionColisionRayo;
        //Physics.Raycast(_rayo, out _informacionColisionRayo, Mathf.Infinity);

        //Vector3 _direction = _informacionColisionRayo.point - transform.position;
        //Quaternion _newRotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(_direction), _rotationTime * Time.deltaTime);
        //_newRotation.x = 0;
        //_newRotation.z = 0;
        //transform.rotation = _newRotation;


    }
    //public void damagerecibe(float damage)
    //{
    //    heal -= damage;
    //    if (heal <= 0)
    //    {
    //        die.SetActive(true);
    //        audimager.sfxsource.Pause();
    //        audimager.sfxsource.volume = 0f;
    //        audimager.musicsource.Pause();
            
    //    }
    //}
}

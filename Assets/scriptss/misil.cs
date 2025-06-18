using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class misil : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float damage;

    float velocidadExtra;
    float dañoOriginal;
    float velocidadOriginal;
    Vector3 escalaOriginal;

    void Awake()
    {
        escalaOriginal = transform.localScale;
        dañoOriginal = damage;
        velocidadOriginal = speed;
    }

    void OnEnable()
    {
        // Reiniciar valores originales
        transform.localScale = escalaOriginal;
        damage = dañoOriginal;
        speed = velocidadOriginal;
        velocidadExtra = 1f;
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * velocidadExtra * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemy"))
        {
            enemy enemigo = other.GetComponent<enemy>();
            if (enemigo != null)
            {
                enemigo.damagerecibe(damage);
            }
            gameObject.SetActive(false);
        }
        else if (other.CompareTag("wall"))
        {
            gameObject.SetActive(false);
        }
    }

    // Métodos para modificar comportamiento desde fuera
    public void SetTamaño(float escala)
    {
        transform.localScale = escalaOriginal * escala;
    }

    public void SetDamage(float nuevoDamage)
    {
        damage = nuevoDamage;
    }

    public void SetVelocidadExtra(float factor)
    {
        velocidadExtra = factor;
    }
}

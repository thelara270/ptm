using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FasterShot : MonoBehaviour
{
    [SerializeField] public float time = 0.08f;
    [SerializeField] public Transform controller; // punto desde el que se dispara
    public audiomanagerc audiomanager;

    void Awake()
    {
        audiomanager = GameObject.FindGameObjectWithTag("audio").GetComponent<audiomanagerc>();
    }

    void Start()
    {
        Disparar(); // iniciar ciclo de disparo
    }
    void OnEnable()
    {
        Disparar(); // reinicia el ciclo de disparo cuando se activa
    }
    void OnDisable()
    {
        CancelInvoke(nameof(Disparar));
    }

    public virtual void Disparar()
    {
        audiomanager.playSFX(audiomanager.fasthot);

        GameObject bullet = bulletpoll.Instace.requestbullet();
        bullet.transform.position = controller.position;
        bullet.transform.rotation = controller.rotation;
        misil m = bullet.GetComponent<misil>();
        if (m != null)
        {
            m.SetTamaño(1f);         // Cambia tamaño visual
            m.SetDamage(0.5f);        // Aumenta daño
            m.SetVelocidadExtra(1f);
        }

        Invoke(nameof(Disparar), time);
    }
}

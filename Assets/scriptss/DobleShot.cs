using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DobleShot : instanciador
{
    public override void Disparar()
    {
        audiomanager.playSFX(audiomanager.shot);

        float offset = 0.3f;

        GameObject bala1 = bulletpoll.Instace.requestbullet();
        bala1.transform.position = controller.position + controller.right * offset;
        bala1.transform.rotation = controller.rotation;

        GameObject bala2 = bulletpoll.Instace.requestbullet();
        bala2.transform.position = controller.position - controller.right * offset;
        bala2.transform.rotation = controller.rotation;
        misil m = bala1.GetComponent<misil>();
        if (m != null)
        {
            m.SetTamaño(1f);         // Cambia tamaño visual
            m.SetDamage(2f);        // Aumenta daño
            m.SetVelocidadExtra(1f);
        }
        misil m2 = bala2.GetComponent<misil>();
        if (m != null)
        {
            m.SetTamaño(1f);         // Cambia tamaño visual
            m.SetDamage(2f);        // Aumenta daño
            m.SetVelocidadExtra(1f);
        }
        Invoke(nameof(Disparar), time);
    }
}

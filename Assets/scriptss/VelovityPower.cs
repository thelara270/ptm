using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MegaPower : instanciador
{
    public override void Disparar()
    {
        audiomanager.playSFX(audiomanager.megaShot);

        GameObject bullet = bulletpoll.Instace.requestbullet();
        bullet.transform.position = controller.position;
        bullet.transform.rotation = controller.rotation;

        misil m = bullet.GetComponent<misil>();
        if (m != null)
        {
            m.SetTama�o(4f);         // Cambia tama�o visual
            m.SetDamage(50f);        // Aumenta da�o
            m.SetVelocidadExtra(4f);
        }

        Invoke(nameof(Disparar), time);
    }
}
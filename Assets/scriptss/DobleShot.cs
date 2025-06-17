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

        Invoke(nameof(Disparar), time);
    }
}

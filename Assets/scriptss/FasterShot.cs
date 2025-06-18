using System.Collections;
using UnityEngine;

public class FasterShot : MonoBehaviour
{
    [SerializeField] public float time = 0.08f; // tiempo entre disparos
    [SerializeField] public float activeDuration = 3f; // tiempo disparando antes de pausar
    [SerializeField] public float pauseDuration = 2f; // tiempo de pausa
    [SerializeField] public Transform controller; // punto desde el que se dispara

    public audiomanagerc audiomanager;

    private Coroutine shootCoroutine;

    void Awake()
    {
        audiomanager = GameObject.FindGameObjectWithTag("audio").GetComponent<audiomanagerc>();
    }

    void OnEnable()
    {
        shootCoroutine = StartCoroutine(DisparoConPausas());
    }

    void OnDisable()
    {
        if (shootCoroutine != null)
            StopCoroutine(shootCoroutine);
    }

    IEnumerator DisparoConPausas()
    {
        while (true)
        {
            float elapsed = 0f;

            // Disparar durante 'activeDuration'
            while (elapsed < activeDuration)
            {
                Disparar();
                yield return new WaitForSeconds(time);
                elapsed += time;
            }

            // Pausar durante 'pauseDuration'
            yield return new WaitForSeconds(pauseDuration);
        }
    }

    public virtual void Disparar()
    {
        audiomanager.playSFX(audiomanager.fasthot);

        GameObject bullet = bulletpoll.Instace.requestbullet();
        bullet.transform.position = controller.position;
        bullet.transform.rotation = controller.rotation;
    }
}

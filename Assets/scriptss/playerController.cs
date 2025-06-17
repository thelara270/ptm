using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    //la posición y la rotación del jugador en relación con el mouse
    public float snapAngle = 45f; // Ángulo de snap en grados
    private Vector3 mousePosition;

    void Update()
    {
        // Obtenemos la posición del ratón en el espacio de la cámara
        mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));

        // Mantenemos la posición del objeto en el eje Y
        Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, mousePosition.z);
        transform.position = newPosition;

        // Obtenemos la dirección hacia el ratón en el plano XZ (ignoramos la altura en Y)
        Vector3 direction = new Vector3(mousePosition.x - transform.position.x, 0f, mousePosition.z - transform.position.z);

        // Calculamos el ángulo entre la dirección y el eje hacia adelante (Vector3.forward)
        float angle = Mathf.Atan2(direction.z, direction.x) * Mathf.Rad2Deg;

        // Aplicamos el snap al ángulo
        float snapValue = Mathf.Round(angle / snapAngle) * snapAngle;

        // Rotamos el objeto solo en el eje Y hacia el ángulo con snap
        transform.rotation = Quaternion.Euler(0f, snapValue, 0f);
    }
}

using UnityEngine;

public class RotacionPersonaje : MonoBehaviour
{
    [SerializeField] Joystick joystick;
    [SerializeField] float velocidadRotacion = 10f;

    void Update()
    {
        RotarSegunJoystick();
    }

    void RotarSegunJoystick()
    {
        float x = joystick.Horizontal;
        float z = joystick.Vertical;

        Vector3 direccion = new Vector3(x, 0f, z);

        if (direccion.magnitude > 0.1f) // Dead zone
        {
            // Calcular ángulo Y hacia el que queremos rotar
            float anguloY = Mathf.Atan2(direccion.x, direccion.z) * Mathf.Rad2Deg;
            Quaternion rotacionObjetivo = Quaternion.Euler(0f, anguloY, 0f);

            // Rotación suave hacia esa dirección
            transform.rotation = Quaternion.Slerp(transform.rotation, rotacionObjetivo, Time.deltaTime * velocidadRotacion);
        }
    }
}

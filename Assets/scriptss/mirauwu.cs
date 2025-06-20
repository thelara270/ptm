//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class mirauwu : MonoBehaviour
//{
//    [Header("Referencias")]
//    [SerializeField] Joystick joystickmove;
//    [SerializeField] Transform cross;
//    [SerializeField] CharacterController controller;

//    [Header("Parámetros de movimiento")]
//    [SerializeField] float speed = 5f;
//    [SerializeField] float suavizado = 10f;

//    private Vector3 direccionDeseada;
//    private Vector3 velocidadActual;

//    void Update()
//    {
//        MoverJugador();
//    }

//    void MoverJugador()
//    {
//        float x = joystickmove.Horizontal + Input.GetAxis("Horizontal");
//        float z = joystickmove.Vertical + Input.GetAxis("Vertical");

//        Vector3 input = new Vector3(x, 0f, z);

//        if (input.magnitude > 0.1f)
//        {
//            // Movimiento en la dirección del "cross"
//            direccionDeseada = cross.right * input.x + cross.forward * input.z;
//            direccionDeseada.y = 0f;
//            direccionDeseada.Normalize();
//        }
//        else
//        {
//            direccionDeseada = Vector3.zero;
//        }

//        // Suavizar movimiento con Lerp
//        velocidadActual = Vector3.Lerp(velocidadActual, direccionDeseada * speed, Time.deltaTime * suavizado);
//        controller.Move(velocidadActual * Time.deltaTime);
//    }
//}

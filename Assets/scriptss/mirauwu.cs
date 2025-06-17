using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mirauwu : MonoBehaviour
{
    //mover un personaje en tercera persona
    [SerializeField] Joystick joystickmove;
    [SerializeField] Transform cross;
    [SerializeField] float speed;

    float x;
    float z;
    Vector3 move;
    [SerializeField] CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    public void Move()
    {
        x = joystickmove.Horizontal + Input.GetAxis("Horizontal");
        z = joystickmove.Vertical + Input.GetAxis("Vertical");
        move = cross.right * x + cross.forward * z;
        controller.Move(move * speed * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    //es el comportamiento general del enemigo(persigue,recibe daño,particulas,puntaje,daño al jugador)
    [SerializeField] Transform playerTransform;
    [SerializeField] float speed = 0.05f;
    [SerializeField] float heal;
    [SerializeField] float damage = 5;
    [SerializeField] int scoregif;
    punta getscore;

    public int cubesPerAxis = 8;    // Número de cubos en cada eje (x, y, z)
    public float delay = 1f;        // Retraso antes de ejecutar la explosión
    public float force = 300f;      // Fuerza de la explosión
    public float radius = 2f;       // Radio de la explosión
    void Start()
    {
        getscore = GameObject.FindGameObjectWithTag("score").GetComponent<punta>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Time.timeScale > 0)
        { 
            Vector3 target = new Vector3(playerTransform.position.x, transform.position.y, playerTransform.position.z);
            transform.position = Vector3.MoveTowards(transform.position, target, speed);
        }
    }

    public void damagerecibe(float damage)
    {
        heal -= damage;
        if (heal <= 0)
        {
            Invoke("Main", delay);
            getscore.scoremas(scoregif);
            gameObject.SetActive(false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<ComponetLife>().damagerecibe(damage);
            gameObject.SetActive(false);
        }
    }

    void Main()
    {
        // Bucle para generar los cubos en cada eje
        for (int x = 0; x < cubesPerAxis; x++)
        {
            for (int y = 0; y < cubesPerAxis; y++)
            {
                for (int z = 0; z < cubesPerAxis; z++)
                {
                    // Llama a la función para crear un cubo en la posición dada
                    CreateCube(new Vector3(x, y, z));
                }
            }
        }

        // Destruir el objeto que contiene el script (este objeto)
        gameObject.SetActive(false);


    }

    void CreateCube(Vector3 coordinate)
    {
        // Resto del código para crear el cubo
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Renderer rd = cube.GetComponent<Renderer>();
        rd.material = GetComponent<Renderer>().material;
        cube.transform.localScale = transform.localScale / cubesPerAxis;

        Vector3 firstCube = transform.position - transform.localScale / 2 + cube.transform.localScale / 2;
        cube.transform.position = firstCube + Vector3.Scale(coordinate, cube.transform.localScale);

        Rigidbody rb = cube.AddComponent<Rigidbody>();
        rb.AddExplosionForce(force, transform.position, radius);
        BoxCollider boxxd = cube.GetComponent <BoxCollider>();
        boxxd.isTrigger = true;

    }
}
   

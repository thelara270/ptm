
using System.Collections.Generic;
using UnityEngine;

public class bulletpoll : MonoBehaviour
{
    //es para reutilizar las balas
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] private int pollzise;
    [SerializeField] List<GameObject> bulletList;

    private static bulletpoll instace;
    public static bulletpoll Instace { get { return instace; } }

    private void Awake()
    {
        if (instace == null)
        {
            instace = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        addbulletstopoll( pollzise);
    }

    private void addbulletstopoll(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            GameObject bullet = Instantiate(bulletPrefab);
            bullet.SetActive(false);
            bulletList.Add(bullet);
            bullet.transform.parent = transform;
        }
    }

    public GameObject requestbullet()
    {
        for(int i = 0;i < bulletList.Count; i++)
        {
            if (!bulletList[i].activeSelf)
            {
                bulletList[i].SetActive(true);
                return bulletList[i];
            }
        }
        addbulletstopoll(1);
        bulletList[bulletList.Count - 1].SetActive(true);
        return bulletList[bulletList.Count - 1];
    }
}

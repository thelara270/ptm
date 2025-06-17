
using System.Collections.Generic;
using UnityEngine;

public class enemypoll : MonoBehaviour
{

    //reutiliza a los enemigos
    [SerializeField] GameObject enemyprefab;
    [SerializeField] GameObject enemyprefab1;
    [SerializeField] GameObject enemyprefab2;
    [SerializeField] GameObject enemyprefab3;
    
    int n;
    [SerializeField] private int pollzise;
    [SerializeField] List<GameObject> enemylist;

    private static enemypoll instance;

    public static enemypoll Instance { get { return instance; } }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        addenemytolipoll(pollzise);
        enemyprefab = null;
    }

    private void addenemytolipoll(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            n = Random.Range(1, 15);
            if (n > 0 && n < 5 )
            {
                enemyprefab = enemyprefab1;
            }
            else if (n > 5 && n < 10)
            {
                enemyprefab = enemyprefab2;
            }
            else
            {
                enemyprefab = enemyprefab3;
            }
            GameObject enemya = Instantiate(enemyprefab);
            enemya.SetActive(false);
            enemylist.Add(enemya);
            enemya.transform.parent = transform;
        }
    }

    public GameObject requestenemy()
    {
        for (int i = 0;i < enemylist.Count; i++)
        {
            if (!enemylist[i].activeSelf)
            {
                enemylist[i].SetActive(true);
                return enemylist[i];
            }
        }
        addenemytolipoll(1);
        enemylist[enemylist.Count - 1].SetActive(true);
        return enemylist[enemylist.Count - 1];
    }
}

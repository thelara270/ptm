using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class punta : MonoBehaviour
{
    // puntuación del jugador en pantalla
    [SerializeField] private float score;

    [SerializeField] TextMeshProUGUI m_TextMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float ScoreActual()
    {
        return score;
    }

    // Update is called once per frame
    void Update()
    {
        m_TextMeshPro.text = score.ToString("0");
    }

    public void scoremas(float currentscore)
    {
        score += currentscore;
    }
}

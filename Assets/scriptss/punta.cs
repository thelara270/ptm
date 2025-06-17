using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class punta : MonoBehaviour
{
    // puntuación del jugador en pantalla
    [SerializeField] private float score;
    [SerializeField] private float scoreEnd;

    [SerializeField] TextMeshProUGUI m_TextMeshPro;
    [SerializeField] TextMeshProUGUI scoreEndText;
    public float ScoreActual()
    {
        return score;
    }

    void Update()
    {
        scoreEnd = score;
        scoreEndText.text= scoreEnd.ToString();
        m_TextMeshPro.text = score.ToString();
    }

    public void scoremas(float currentscore)
    {
        score += currentscore;

        // Actualiza el máximo si se supera
        float mejorPuntaje = PlayerPrefs.GetFloat("HighScore", 0f);
        if (score > mejorPuntaje)
        {
            PlayerPrefs.SetFloat("HighScore", score);
            PlayerPrefs.Save();
        }

    }

}

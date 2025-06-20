using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class punta : MonoBehaviour
{
    // puntuaci�n del jugador en pantalla
    [SerializeField] private int score;
    [SerializeField] private int scoreEnd;

    [SerializeField] TextMeshProUGUI m_TextMeshPro;
    [SerializeField] TextMeshProUGUI scoreEndText;
    public int ScoreActual()
    {
        return score;
    }

    void Update()
    {
        scoreEnd = score;
        scoreEndText.text= scoreEnd.ToString();
        m_TextMeshPro.text = score.ToString();
    }

    public void scoremas(int currentscore)
    {
        score += currentscore;

        // Actualiza el m�ximo si se supera
        float mejorPuntaje = PlayerPrefs.GetFloat("HighScore", 0f);
        if (score > mejorPuntaje)
        {
            PlayerPrefs.SetFloat("HighScore", score);
            PlayerPrefs.Save();
        }

    }

}

using UnityEngine;
using TMPro;

public class MostrarMejorPuntaje : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textoRecord;

    void Start()
    {
        float mejorPuntaje = PlayerPrefs.GetFloat("HighScore", 0f); // <- usa la misma clave
        textoRecord.text = mejorPuntaje.ToString("0");
    }

}

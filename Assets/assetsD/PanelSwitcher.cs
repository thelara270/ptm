using UnityEngine;

public class PanelSwitcher : MonoBehaviour
{
    public GameObject currentPanel;
    public GameObject nextPanel;
    public GameObject boton;
    public GameObject animacion;

    public void SwitchPanel()
    {
        currentPanel.SetActive(false);
        nextPanel.SetActive(true);
    }

    public void SkipPanel()
    {
        currentPanel.SetActive(true);
        nextPanel.SetActive(false);
        boton.SetActive(false);
        animacion.SetActive(false);
    }
}

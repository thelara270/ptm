using UnityEngine;

public class PanelSwitcher : MonoBehaviour
{
    public GameObject currentPanel;
    public GameObject nextPanel;

    public void SwitchPanel()
    {
        currentPanel.SetActive(false);
        nextPanel.SetActive(true);
    }
}

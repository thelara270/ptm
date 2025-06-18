using UnityEngine;
using System.Collections;

public class AnimationCinematicController : MonoBehaviour
{
    public Animation animationComponent;
    public string animationName;
    public GameObject panelToShow;

    void Start()
    {
        StartCoroutine(WaitForAnimationEnd());
    }

    IEnumerator WaitForAnimationEnd()
    {
        AnimationState animState = animationComponent[animationName];
        yield return new WaitForSeconds(animState.length);

        panelToShow.SetActive(true);
    }
}
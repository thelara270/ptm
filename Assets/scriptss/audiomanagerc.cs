using UnityEngine;

public class audiomanagerc : MonoBehaviour
{
    //maneja el audio
    [Header("----------------AudioSource-----------------------")]
    [SerializeField] public AudioSource musicsource;
    [SerializeField] public AudioSource sfxsource;

    [Header("-----------------AudioClip-------------------------")]
    public AudioClip bacground;
    public AudioClip play;
    public AudioClip shot;
    public AudioClip fasthot;
    public AudioClip megaShot;
    public AudioClip enemy;
    public AudioClip player;
    public AudioClip butonselect;

    private void Start()
    {
        musicsource.clip = bacground;
        musicsource.Play();
    }

    public void playSFX(AudioClip clip)
    {
        sfxsource.PlayOneShot(clip);
    }

}

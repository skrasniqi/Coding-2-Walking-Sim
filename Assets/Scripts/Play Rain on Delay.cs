using UnityEngine;

public class PlayRainonDelay : MonoBehaviour
{
    public float delayTime;
    public ParticleSystem rainparticles;
    private AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
        Invoke("Rain", delayTime);

    }

    private void Rain()
    {
        audio.Play();
        rainparticles.Play();
    }
}

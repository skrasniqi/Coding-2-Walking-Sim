using UnityEngine;
using UnityEngine.Audio;

public class AudioController : MonoBehaviour
{
    public AudioMixerSnapshot unmutedSnapshot;
    public AudioMixerSnapshot mutedSnapshot;

    private AudioSource audio;
    private AudioMixer mixer;
    private float[] weights;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            audio = GetComponent<AudioSource>();
            mixer = audio.outputAudioMixerGroup.audioMixer;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {

        }
    }
}

using System.Collections;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Audio : MonoBehaviour
{
    public float fadeTimeInSeconds;

    private AudioSource audio;

    private void Start()
    {
       audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            StopAllCoroutines();
            StartCoroutine(FadeAudio(true));
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            StopAllCoroutines();
            StartCoroutine(FadeAudioOut(true));
            audio.Pause();
        }
    }


    //Audio fade in
    private IEnumerator FadeAudio(bool fadeIn)
    {
        float timer = 0;
        //if fadeIn is true, set to 0, else set to 1
        float start = fadeIn ? 0 : 1;
        //if fadeIn is true, set to 1, else set to 0
        float end = fadeIn ? 1 : 0;

        if(fadeIn) audio.Play();
        while(timer < fadeTimeInSeconds)
        {
            //smoothly increase volume from 0 to 1
            //timer / fadeTimeInSeconds represents timer's percentage towards the amount of time we are fading
            //i.e. if fadeTime is 2s, and timer is 1s, 1 / 2 = 0.5 (50% towards 2s)
            audio.volume = Mathf.Lerp(0, 1, timer / fadeTimeInSeconds);
            timer += Time.deltaTime;
            yield return null;
        }
        audio.volume = end;
        if (!fadeIn) audio.Pause();
    }

    //Audio fade out
    private IEnumerator FadeAudioOut(bool fadeOut)
    {
        float timer = 1;

        audio.Play();
        while (timer < fadeTimeInSeconds)
        {
            audio.volume = Mathf.Lerp(1, 0, timer / fadeTimeInSeconds);
            timer += Time.deltaTime;
            yield return null;
        }
        audio.volume = 0;
        audio.Pause();
    }
}

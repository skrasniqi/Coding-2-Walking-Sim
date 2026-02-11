using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class DontLookBack : MonoBehaviour
{

    public Image _sceneFadeImage;
    public float fadeTimeInSeconds;

    private void Awake()
    {
        _sceneFadeImage = GetComponent<Image>();
    }


    // Update is called once per frame
    void Update()
    {
       // if(transform.localEulerAngles.y < -165 || transform.localEulerAngles.y > 165)
       if(transform.rotation.y < -165 || transform.rotation.y > 165)
        {
            StartCoroutine(FadeScene(true));
            SceneManager.LoadScene("Mourning Fields");
        }
    }

    private IEnumerator FadeScene(bool fadeIn)
    {
        float timer = 0;
        //if fadeIn is true, set to 0, else set to 1
        float start = fadeIn ? 0 : 1;
        //if fadeIn is true, set to 1, else set to 0
        float end = fadeIn ? 1 : 0;

        if(fadeIn);
        while(timer < fadeTimeInSeconds)
        {
            //smoothly increase volume from 0 to 1
            //timer / fadeTimeInSeconds represents timer's percentage towards the amount of time we are fading
            //i.e. if fadeTime is 2s, and timer is 1s, 1 / 2 = 0.5 (50% towards 2s)
            timer += Time.deltaTime;
            yield return null;
        }
    }
}

using UnityEngine;

public class LanternFlicker : MonoBehaviour
{

    public Light mySpotLight;
    private bool turnOffOnExit = true;

    //private AudioSource lightFlicker;

   
    void Start()
    {
        if(mySpotLight != null)
        {
            mySpotLight.enabled = false;
        }

        //audio = GetComponent<AudioSource>();
    }


    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if(mySpotLight.enabled != null)
            {
                 mySpotLight.enabled = true;
            }
        }
    }
}

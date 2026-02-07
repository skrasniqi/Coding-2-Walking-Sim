using UnityEngine;

public class LanternFlicker : MonoBehaviour
{

    public Light mySpotLight;
    private bool turnOffOnExit = true;

   
    void Start()
    {
        if(mySpotLight != null)
        {
            mySpotLight.enabled = false;
        }
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

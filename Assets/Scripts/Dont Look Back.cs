using UnityEngine;
using UnityEngine.SceneManagement;

public class DontLookBack : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.localEulerAngles.y < -165 || transform.localEulerAngles.y > 165)
        {
            
            SceneManager.LoadScene("Mourning Fields");
        }
    }
}

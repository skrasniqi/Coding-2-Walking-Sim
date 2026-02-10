using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Load the next scene or perform the desired transition
            // For example, you can use SceneManager.LoadScene to load a new scene
            // SceneManager.LoadScene("NextSceneName");
            SceneManager.LoadScene("Styx");
            Debug.Log("Player entered the trigger area. Transitioning to the next scene...");
        }
    }
}


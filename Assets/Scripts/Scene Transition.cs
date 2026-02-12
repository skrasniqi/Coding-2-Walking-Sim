using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
   /*public void LoadNextScene()
   {
    int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    int nextSceneIndex = (currentSceneIndex + 1);
   }*/
    private int currentScene;

    private void Start()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            currentScene = SceneManager.GetActiveScene().buildIndex;

            if (currentScene == 0)
            {
                SceneManager.LoadScene(1);
            }
            else if(currentScene == 1)
            {
                SceneManager.LoadScene(2);
            }






            // Load the next scene or perform the desired transition
            // For example, you can use SceneManager.LoadScene to load a new scene
            // SceneManager.LoadScene("NextSceneName");
            
            //SceneManager.LoadScene("Styx");
            //Debug.Log("Player entered the trigger area. Transitioning to the next scene...");
        }
    }
}


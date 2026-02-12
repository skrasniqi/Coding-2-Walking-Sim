using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition2 : MonoBehaviour
{
   // Start is called once before the first execution of Update after the MonoBehaviour is created
   
   /*public void LoadNextScene()
   {
    int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    int nextSceneIndex = (currentSceneIndex + 1);
   }*/

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Load the next scene or perform the desired transition
            // For example, you can use SceneManager.LoadScene to load a new scene
            // SceneManager.LoadScene("NextSceneName");
            SceneManager.LoadScene("Almost Home");
            Debug.Log("Player entered the trigger area. Transitioning to the next scene...");
        }
    }
}

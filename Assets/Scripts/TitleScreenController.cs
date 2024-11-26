using System.Collections; // Add this for IEnumerator
using UnityEngine;
using UnityEngine.SceneManagement;  // To manage scene transitions

public class TitleScreenController : MonoBehaviour
{
    // This method will be called when the scene starts
    private void Start()
    {
        // Start the coroutine to wait for 3 seconds before starting the game
        StartCoroutine(StartGameAfterDelay());
    }

    // Coroutine to wait for a specified time and then load the game scene
    private IEnumerator StartGameAfterDelay()
    {
        // Wait for 3 seconds
        yield return new WaitForSeconds(3f);

        // Load the main game scene (change "GameScene" to your actual scene name)
        SceneManager.LoadScene("SampleScene");
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class nextSceneTransition : MonoBehaviour
{
    public void sceneChangeNextLevel()
    {
        SceneManager.LoadScene("MainLevelFinale");
    }

    public void sceneChangeToMainLevel()
    {
        SceneManager.LoadScene("MainLevel");
    }

    public void sceneChangeToFailMenu()
    {
        SceneManager.LoadScene("FailedMenu");
    }

    public void sceneChangeToCompletionMenu()
    {
        SceneManager.LoadScene("GameComplete");
    }

    public void sceneChangeToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSelect : MonoBehaviour
{
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

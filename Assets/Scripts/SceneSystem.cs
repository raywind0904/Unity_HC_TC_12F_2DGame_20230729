using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSystem : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("遊戲場景");
    }

    public void QuitGame()
    {
        print("<color=yellow>離開遊戲</color>");
        Application.Quit();
    }
}

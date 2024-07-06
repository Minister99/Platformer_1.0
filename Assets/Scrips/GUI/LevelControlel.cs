using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControlel : MonoBehaviour
{
    public void LevelSelection(int numbelLevel)
    {
        SceneManager.LoadScene(numbelLevel);
    }

    public void Pause()
    {
        Time.timeScale = 0f;
    }

    public void Play()
    {
        Time.timeScale = 1f;
    }

    public void RestartLevel() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextLevel()
    {
        int nexLevel = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + nexLevel);
    }
}

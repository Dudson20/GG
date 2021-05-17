using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    [SerializeField] int TimeToWait = 5;
    int currensSceneIndex;

    // Start is called before the first frame update
    void Start()
    {
        currensSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currensSceneIndex == 0)
        {
            StartCoroutine(WaitForTime());
        }
    }

    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(TimeToWait);
        LoadNextScene();
;   }

    public void RestartScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(currensSceneIndex);
    }
    public void LoadMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Start");
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currensSceneIndex + 1);
    }

    public void LoadGameOver()
    {
        SceneManager.LoadScene("Game Over");
    }

    public void QuitGame()
    {
        Application.Quit(); 
    }
}

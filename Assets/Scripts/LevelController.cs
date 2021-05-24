using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{

    [SerializeField] float waitToLoad = 5f;
    [SerializeField] GameObject WinLabel;
    [SerializeField] GameObject LoseLabel;
    int NumerOfAttackers = 0;
    bool levelTimerFinished = false;

    private void Start()
    {
        WinLabel.SetActive(false); 
        LoseLabel.SetActive(false);
    }

    public void AttackerSpawned()
    {
        NumerOfAttackers++;
    }
    public void AttackerKilled()
    {
        NumerOfAttackers--;
        var getBaseHealth = FindObjectOfType<healthDisplay>().GetBaseHealth();
        if (NumerOfAttackers <= 0 && levelTimerFinished && getBaseHealth > 0)
        {
              StartCoroutine(HandleWinCondition());
        }
    }

    IEnumerator HandleWinCondition()
    {
        WinLabel.SetActive(true);
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(waitToLoad);
        FindObjectOfType<LoadLevel>().LoadNextScene();
    }

    public void LoseCoindition()
    {
        LoseLabel.SetActive(true);
        Time.timeScale = 0;
    }


    public void LevelTimerFinished()
    {
        levelTimerFinished = true;
        StopSpawners();
    }

    private static void StopSpawners()
    {
        EnemySpawner[] spawnerArray = FindObjectsOfType<EnemySpawner>();
        foreach (EnemySpawner spawner in spawnerArray)
        {
            spawner.StopSpawning();
        }
    }
}

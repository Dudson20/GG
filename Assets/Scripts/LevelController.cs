using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{

    [SerializeField] float waitToLoad = 5f;
    [SerializeField] GameObject WinLabel;
    int NumerOfAttackers = 0;
    bool levelTimerFinished = false;

    private void Start()
    {
        WinLabel.SetActive(false);
    }

    public void AttackerSpawned()
    {
        NumerOfAttackers++;
    }
    public void AttackerKilled()
    {
        NumerOfAttackers--;
        if (NumerOfAttackers <= 0 && levelTimerFinished)
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

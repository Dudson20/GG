using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] float MinSpawnDelay = 1f;
    [SerializeField] float MaxSpawnDelay = 5f;
    [SerializeField] Attacker[] attackerPrefab;

    bool spawn = true;

    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(MinSpawnDelay, MaxSpawnDelay));
            SpawnAttacker();
        }
    }

    public void StopSpawning()
    {
        spawn = false;
    }

    private void SpawnAttacker()
    {
       // if (spawn) //delay na spawnowanie, usun¹æ if
       // {
            var attackerIndex = Random.Range(0, attackerPrefab.Length);
            Spawn(attackerPrefab[attackerIndex]);
      //  }
    }


    private void Spawn(Attacker myAttacker)
    {
        Attacker newAttacker = Instantiate(myAttacker, transform.position, transform.rotation) as Attacker;
        newAttacker.transform.parent = transform;
    }


}

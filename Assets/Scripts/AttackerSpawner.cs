using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{

    // should it spawn or not 
    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;
    [SerializeField] Attacker [] attackerPrefabs;


    bool spawn =  true;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (spawn) {
            yield return new WaitForSeconds(UnityEngine.Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttacker();
        }
    }

    private void SpawnAttacker() {
        if (spawn == false) { return; }
        Attacker newAttacker = Spawn(UnityEngine.Random.Range(0, attackerPrefabs.Length - 1));
        newAttacker.transform.parent = transform;
    }

    // randomly spawn attackers based on the index

    private Attacker Spawn(int index)
    {
        return Instantiate(attackerPrefabs[index], transform.position, transform.rotation) as Attacker;
    }

    public void StopSpawning()
    {
        spawn = false;
        Debug.Log("Attacker spwners now stop!");
    }
}

  


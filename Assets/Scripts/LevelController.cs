using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    int numberOfAttackers = 0;
    bool timerIsDone = false;
    public void leverTimerDone()
    {
        timerIsDone = true;
        StopSpawners();
    }

    private void StopSpawners()
    {
        AttackerSpawner[] attackerSpawnersArray = FindObjectsOfType<AttackerSpawner>();
        foreach (AttackerSpawner spawner in attackerSpawnersArray)
        {
            spawner.StopSpawning();
        }
    }

    public void AttackerSpawned()
    {
        numberOfAttackers++;
    }

    public void AttackerKilled()
    {
        numberOfAttackers--;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsDone && numberOfAttackers <= 0)
        {
            Debug.Log("Game level is complete!");
            
        }
        
    }
}

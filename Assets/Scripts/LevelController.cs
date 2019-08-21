using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] GameObject winLabel;
    [SerializeField] GameObject loseLabel;

    [SerializeField] float waitToLoad;
 

    int numberOfAttackers = 0;
    bool timerIsDone = false;


    void Start()
    {
        winLabel.SetActive(false);
        loseLabel.SetActive(false);


    }

    public void leverTimerDone()
    {
        timerIsDone = true;
        StopSpawners();
    }

    public void HandleLoseCondition()
    {
        Time.timeScale = 0;
        loseLabel.SetActive(true);
     
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
            StartCoroutine(levelIsDone());
            
        }
        
    }

    IEnumerator levelIsDone()
    {
        GetComponent<AudioSource>().Play();
        winLabel.SetActive(true);
        yield return new WaitForSeconds(waitToLoad);
        FindObjectOfType<LevelLoader>().LoadNextScene();

    }
}

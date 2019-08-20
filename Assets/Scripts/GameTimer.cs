using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [Tooltip("Our level timer in seconds.")] 
    [SerializeField] float levelTime = 10;
    bool triggerLevelDone = false;


    private bool timerDone;

    void Update()
    {
        if(triggerLevelDone) { return;  }

        GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelTime;

        timerDone = (Time.timeSinceLevelLoad >= levelTime);
        if (timerDone)
        {
            FindObjectOfType<LevelController>().leverTimerDone();
            triggerLevelDone = true;
            Debug.Log("timer is done");
        }
    }

}

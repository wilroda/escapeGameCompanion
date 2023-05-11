using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerCountUp : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float secondsCount;
    private int minuteCount;
    private int hourCount;

    // Update is called once per frame
    void Update()
    {
        UpdateTimerUI();
    }

    //call this on update
    public void UpdateTimerUI(){
        //set timer UI
        secondsCount += Time.deltaTime;
        timerText.text = string.Format("{0:00}:{1:00}", minuteCount, (int)secondsCount);
        if(secondsCount >= 60){
            minuteCount++;
            secondsCount = 0;
        }else if(minuteCount >= 60){
            hourCount++;
            minuteCount = 0;
        }    
    }
}

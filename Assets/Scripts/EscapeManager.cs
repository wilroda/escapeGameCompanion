using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class EscapeManager : MonoBehaviour
{
    public TextMeshProUGUI _timer;
    public TextMeshProUGUI _mission;
    public  Image _QR;
    public TMP_InputField _answer;
    public Camera _camera;
    
    private float secondsCount;
    private int minuteCount;
    private int hourCount;
    private int missionCount = 1;

    // Start is called before the first frame update
    void Start()
    {
        MissionUpdate();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTimerUI();
    }

    //call this on update
    public void UpdateTimerUI(){
        //set timer UI
        secondsCount += Time.deltaTime;
        _timer.text = string.Format("{0:00}:{1:00}", minuteCount, (int)secondsCount);
        if(secondsCount >= 60){
            minuteCount++;
            secondsCount = 0;
        }else if(minuteCount >= 60){
            hourCount++;
            minuteCount = 0;
        }    
    }

    public void MissionUpdate()
    {
        _mission.text = "Mission " + missionCount;
    }

    public void Validator()
    {
        switch (missionCount)
        {
            case 1:
                if(_answer.text.ToLower() == "b")
                {
                    missionCount++;
                    MissionUpdate();
                    Debug.Log("Mission Successful!");
                    break;       
                }
                minuteCount += 3;
                Debug.Log("Wrong answer, try again!");
                break;       

            case 2:
                if(_answer.text.ToLower() == "abcde")
                {
                    missionCount++;
                    MissionUpdate();
                    Debug.Log("Mission Successful!");
                    break;       
                }
                minuteCount += 3;
                Debug.Log("Wrong answer, try again!");
                break;       

            case 3:
                if(_answer.text.ToLower() == "78")
                {
                    missionCount++;
                    MissionUpdate();
                    Debug.Log("Mission Successful!");
                    break;       
                }
                minuteCount += 3;
                Debug.Log("Wrong answer, try again!");
                break;      

        }
    }
}
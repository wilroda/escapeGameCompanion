using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class EscapeManager : MonoBehaviour
{
    public TextMeshProUGUI _timer;
    public TextMeshProUGUI _mission;
    public  Image _QR;    
    public TMP_Text _answer = null;
    // public Camera _camera;
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
        _timer.text = string.Format("{0:00}:{1:00}:{2:00}", hourCount, minuteCount, (int)secondsCount);
        if(secondsCount >= 60){
            minuteCount++;
            secondsCount = 0;
        }else if(minuteCount >= 60){
            hourCount++;
            minuteCount = 0;
        }    
    }

    public void KeyboardTyping(Button keyboardButton)
    {
        string keyText = keyboardButton.GetComponentInChildren<TMP_Text>().text;

        if(keyText == "del")
        {
            string tempGetString = _answer.text;

            if(tempGetString.Length > 0)
            {
                string tempString = tempGetString.Substring(0, tempGetString.Length -1);
                _answer.text = tempString;
            }
            
        }
        else
        {
            _answer.text += keyText;
        }
    }

    public void MissionUpdate()
    {
        _mission.text = "MISSION " + missionCount;
    }

    public void ClearText(TMP_Text inputField)
    {
        inputField.text = "";
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
                    ClearText(_answer);
                    Debug.Log("Mission Successful!");
                    break;       
                }
                minuteCount += 3;
                ClearText(_answer);
                Debug.Log("Wrong answer, try again!");
                break;       

            case 2:
                if(_answer.text.ToLower() == "23")
                {
                    missionCount++;
                    MissionUpdate();
                    ClearText(_answer);
                    Debug.Log("Mission Successful!");
                    break;       
                }
                minuteCount += 3;
                ClearText(_answer);
                Debug.Log("Wrong answer, try again!");
                break;       

            case 3:
                if(_answer.text.ToLower() == "abca")
                {
                    missionCount++;
                    MissionUpdate();
                    ClearText(_answer);
                    Debug.Log("Mission Successful!");
                    break;       
                }
                minuteCount += 3;
                ClearText(_answer);
                Debug.Log("Wrong answer, try again!");
                break;   
                
            case 4:
                if(_answer.text.ToLower() == "radio")
                {
                    missionCount++;
                    MissionUpdate();
                    ClearText(_answer);
                    Debug.Log("Mission Successful!");
                    break;       
                }
                minuteCount += 3;
                ClearText(_answer);
                Debug.Log("Wrong answer, try again!");
                break;         

            case 5:
                if(_answer.text.ToLower() == "idho")
                {
                    missionCount++;
                    MissionUpdate();
                    ClearText(_answer);
                    Debug.Log("Mission Successful!");
                    break;       
                }
                minuteCount += 3;
                ClearText(_answer);
                Debug.Log("Wrong answer, try again!");
                break; 

            case 6:
                if(_answer.text.ToLower() == "bbaacabbba")
                {
                    missionCount++;
                    MissionUpdate();
                    ClearText(_answer);
                    Debug.Log("Mission Successful!");
                    break;       
                }
                minuteCount += 3;
                ClearText(_answer);
                Debug.Log("Wrong answer, try again!");
                break;
            
            case 7:
                if(_answer.text.ToLower() == "b")
                {
                    MissionUpdate();
                    ClearText(_answer);
                    Debug.Log("Mission Successful!");
                    break;       
                }
                minuteCount += 3;
                ClearText(_answer);
                Debug.Log("Wrong answer, try again!");
                break;

        }
    }
}

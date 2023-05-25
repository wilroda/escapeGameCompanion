using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class EscapeManager : MonoBehaviour
{
    public TextMeshProUGUI timer;
    public TextMeshProUGUI mission;
    public TextMeshProUGUI briefing;
    public  Image _QR;    
    public TMP_Text answer;

    public AudioSource keyboardSound;
    public AudioSource validSound;
    public AudioSource invalidSound;

    public GameObject gameScreen;
    public GameObject endScreen;

    public TextMeshProUGUI gameTime;
    public TextMeshProUGUI rank;
    private float secondsCount;
    private int minuteCount;
    private int hourCount;
    private int missionCount = 1;
    private int missionDisplay = 1;
    private bool gameIsOver = false;

    public string answer1;
    public string answer2;
    public string answer3;
    public string answer4;
    public string answer5;
    public string answer6;
    public string answer7;
    public string answer8;
    public string answer9;
    public string answer10;
    public string answer11;
    public string answer12;
    public string answer13;

    char[] answer6Characters = new char[10];
    char[] answer4Characters = new char[4];

    void Start()
    {
        // Set Mission 1 from the start.
        MissionUpdate();
        BriefUpdate(missionCount);
    }

    void Update()
    {
        UpdateTimerUI();
    }

    public void Answer4Check()
    {
        if(answer4Characters[0] == 'A' | answer4Characters[0] == 'B')
        {
            if(answer4Characters[1] == 'B')
            {
                if(answer4Characters[2] == 'C')
                {
                    if(answer4Characters[3] == 'A' | answer4Characters[3] == 'B')
                    {
                        CorrectResponse();
                    }
                    else
                    {
                        InvalidResponse();
                    }
                }
                else
                {
                    InvalidResponse();
                }
            }
            else
            {
                InvalidResponse();
            }
        }
        else
        {
            InvalidResponse();
        }
    }                                           
                                            
    public void Answer6Check()
    {
        if(answer6Characters[0] == 'B')
        {
            if(answer6Characters[1] == 'B')
            {
                if(answer6Characters[2] == 'A' | answer6Characters[2] == 'B')
                {
                    if(answer6Characters[3] == 'A' | answer6Characters[3] == 'B')
                    {
                        if(answer6Characters[4] == 'C')
                        {
                            if(answer6Characters[5] == 'A' | answer6Characters[5] == 'B')
                            {
                                if(answer6Characters[6] == 'B')
                                {
                                    if(answer6Characters[7] == 'B')
                                    {
                                        if(answer6Characters[8] == 'B')
                                        {
                                            if(answer6Characters[9] == 'A' | answer6Characters[9] == 'B')
                                            {
                                                CorrectResponse();       
                                            }
                                            else
                                            {
                                                InvalidResponse();
                                            }
                                        }
                                        else
                                        {
                                            InvalidResponse();
                                        }
                                    }
                                    else
                                    {
                                        InvalidResponse();
                                    }
                                }
                                else
                                {
                                    InvalidResponse();
                                }
                            }
                            else
                            {
                                InvalidResponse();
                            }
                        }
                        else
                        {
                            InvalidResponse();
                        }
                    }
                    else
                    {
                        InvalidResponse();
                    }
                }
                else
                {
                    InvalidResponse();
                }
            }
            else
            {
                InvalidResponse();
            }
        } 
        else
        {
            InvalidResponse();
        }
    }
    public void AnswerToCharacters(string text, char[]characterArray)
    {
        using (StringReader sr = new StringReader(text))
        {
            sr.Read(characterArray,0,text.Length);
        }
    }

    public void UpdateTimerUI(){

        if(gameIsOver != true)
        {
            //Set TimerUI
            secondsCount += Time.deltaTime;
            timer.text = string.Format("{0:00}:{1:00}:{2:00}", hourCount, minuteCount, (int)secondsCount);
            if(secondsCount >= 60){
                minuteCount++;
                secondsCount = 0;
            }else if(minuteCount >= 60){
                hourCount++;
                minuteCount = 0;
            }    
        }
    }

    public void BriefUpdate(int currentMission)
    {
        switch (currentMission)
        {
            // Mission 1
            case 1:
            briefing.text = "Mission Specialists, follow the mission plan and stay alert!";
            break;

            // Mission 2
            case 2:
            briefing.text = "Robotics Sector online, great job!\n\nWe need to contact earth for a status update.";
            break;

            // Mission 3
            case 3:
            briefing.text = "Good job Mission Specialists!\n\nThe antenna is fixed and we are very close to being able to contact earth.";
            break;

            // Mission 4
            case 4:
            briefing.text = "Check the map and see what DNS location we can contact!";
            break;

            // Mission 5
            case 5:
            briefing.text = "I'm picking up a signal from earth but there is a strong interference and I can't quite make out the message.\n\nCheck the noise waveform, it needs to be canceled.";
            break;

            // Mission 6
            case 6:
            briefing.text = "Ok Mission Specialists, we need to increase our fuel so that we can get the ship into the earth's orbit";
            break;

            // Mission 7 Checkpoint 2
            case 7:
            briefing.text = "It seems the necessary items for fuel production are on a sector that became inaccessible to the crew after the meteor impact.";
            break;

            // Mission 7 Checkpoint 3
            case 8:
            briefing.text = "4 more checkpoints to go! ";
            break;

            // Mission 7 Checkpoint 4
            case 9:
            briefing.text = "3 more checkpoints to go! ";
            break;

            // Mission 7 Checkpoint 5
            case 10:
            briefing.text = "2 more checkpoints to go! ";
            break;

            // Mission 7 Checkpoint 6
            case 11:
            briefing.text = "1 more checkpoints to go! ";
            break;

            // Mission 8
            case 12:
            briefing.text = "Team, we are almost there!\n\nLet's fix the Water Recycling System so we can keep on our path of producing fuel.";
            break;

            // Mission 9
            case 13:
            briefing.text = "Great job Mission Specialists, we have all the components and are one step away from producing the fuel needed.\n\nMaster the process of electrolysis and we can get back to earth!";
            break;
        }
    }

    public void Validator()
    {
        switch (missionCount)
        {
            case 1:
                if(answer.text.ToLower() == answer1)
                {
                    CorrectResponse();
                    break;       
                }
                InvalidResponse();
                break;       

            case 2:
                if(answer.text.ToLower() == answer2)
                {
                    CorrectResponse();
                    break;       
                }
                InvalidResponse();
                break;       

            case 3:
                answer.text.ToLower();
                AnswerToCharacters(answer.text, answer4Characters);
                Answer4Check();
                break;
                
            case 4:
                if(answer.text.ToLower() == answer4)
                {
                    CorrectResponse();
                    break;       
                }
                InvalidResponse();
                break;         

            case 5:
                if(answer.text.ToLower() == answer5)
                {
                    CorrectResponse();
                    break;       
                }
                InvalidResponse();
                break; 

            case 6:
                answer.text.ToLower();
                AnswerToCharacters(answer.text, answer6Characters);
                Answer6Check();
                break;

            
            case 7:
                if(answer.text.ToLower() == answer7)
                {
                    CorrectResponseCheckpoint();
                    break;       
                }
                InvalidResponse();
                break;

            case 8:
                if(answer.text.ToLower() == answer8)
                {
                    CorrectResponseCheckpoint();
                    break;       
                }
                InvalidResponse();
                break;

            case 9:
                if(answer.text.ToLower() == answer9)
                {
                    CorrectResponseCheckpoint();
                    break;       
                }
                InvalidResponse();
                break;

            case 10:
                if(answer.text.ToLower() == answer10)
                {
                    CorrectResponseCheckpoint();
                    break;       
                }
                InvalidResponse();
                break;

            case 11:
                if(answer.text.ToLower() == answer11)
                {
                    CorrectResponse();
                    break;       
                }
                InvalidResponse();
                break;

            case 12:
                if(answer.text.ToLower() == answer12)
                {
                    CorrectResponse();
                    break;       
                }
                InvalidResponse();
                break;

            case 13:
                if(answer.text.ToLower() == answer13)
                {
                    CorrectResponse();
                    GameOver();
                    break;       
                }
                InvalidResponse();
                break;
        }
    }

    // Mission Count Update
    public void MissionUpdate()
    {
        mission.text = "MISSION " + missionDisplay;
    }

    // On-screen Keyboard
    public void KeyboardTyping(Button keyboardButton)
    {
        string keyText = keyboardButton.GetComponentInChildren<TMP_Text>().text;

        if(keyText == "del")
        {
            string tempGetString = answer.text;
            keyboardSound.Play();

            if(tempGetString.Length > 0)
            {
                string tempString = tempGetString.Substring(0, tempGetString.Length -1);
                answer.text = tempString;
            }
        }
        else
        {
            keyboardSound.Play();
            answer.text += keyText;
        }
    }

    // Clear Text Field
    public void ClearText(TMP_Text inputField)
    {
        inputField.text = "";
    }

    // Invalid Response Logic
    public void InvalidResponse()
    {
        keyboardSound.Play();
        invalidSound.Play();
        //minuteCount += 3;
        ClearText(answer);
        Debug.Log("Invalide response, try again!");
    }

    // Correct Response Logic
    public void CorrectResponse()
    {
        keyboardSound.Play();
        validSound.Play();
        missionCount++;
        missionDisplay++;
        MissionUpdate();
        BriefUpdate(missionCount);
        ClearText(answer);
        Debug.Log("Mission Successful!");
    }

    public void CorrectResponseCheckpoint()
    {
        keyboardSound.Play();
        validSound.Play();
        missionCount++;
        MissionUpdate();
        BriefUpdate(missionCount);
        ClearText(answer);
        Debug.Log("Mission Successful!");
    }

    public void GameOver()
    {
        gameIsOver = true;

        gameTime.text = timer.text;

        if(hourCount < 1)
        {
            if(minuteCount <= 30)
                rank.text = "mission specialists";
            else if (minuteCount <= 40)
                rank.text = "space pilots";
            else 
                rank.text = "space cadets";
        }
        else
            rank.text = "adrift";
        
        gameScreen.SetActive(false);
        endScreen.SetActive(true);               
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ValidateAnswer : MonoBehaviour
{
    public TMP_InputField answer;
    private int missionCount = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void Validator()
    {
        switch (missionCount)
        {
            case 1:
                if(answer.text.ToLower() == "b")
                {
                    missionCount++;
                    Debug.Log("Mission Successful!");
                    break;       
                }
                Debug.Log("Wrong answer, try again!");
                break;       

            case 2:
                if(answer.text.ToLower() == "abcde")
                {
                    missionCount++;
                    Debug.Log("Mission Successful!");
                    break;       
                }
                Debug.Log("Wrong answer, try again!");
                break;       

            case 3:
                if(answer.text.ToLower() == "78")
                {
                    missionCount++;
                    Debug.Log("Mission Successful!");
                    break;       
                }
                Debug.Log("Wrong answer, try again!");
                break;      

        }
    }
}

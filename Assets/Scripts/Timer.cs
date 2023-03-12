using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float timeToShowCorrectAnswer = 10f;
    
    public bool isAnsweringQuestion = false;
    public float fillFraction;

    float timerValue;

    void Update()
    {
        UpdateTimer();
    }

    void UpdateTimer()
    {
        timerValue -= Time.deltaTime;

        if(isAnsweringQuestion)
        {
            if(timerValue >0)
            {
                fillFraction = (timerValue / timeToCompleteQuestion);
            }

            if(timerValue <=0)
            {
                isAnsweringQuestion = false;
                timerValue = timeToShowCorrectAnswer;
            }
        }
        else
        {
            if(timerValue >0)
            {
                fillFraction = (timerValue / timeToShowCorrectAnswer);
            }

            if(timerValue <=0)
            {
                isAnsweringQuestion = true;
                timerValue = timeToCompleteQuestion;
            }
        }

        Debug.Log($"isAnsweringQuestion: {isAnsweringQuestion}, timerValue: {timerValue}, fillFraction: {fillFraction}");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WInScript : MonoBehaviour
{
    private int pointsToWin;
    private int currentPoints;
    //public GameObject myWords;   
    public GameObject continueButton;  
    //public Image donePopUp; 

    void Start()
    {
        pointsToWin = 5;
        //pointsToWin = myWords.transform.childCount;
        //sätt av knappen 
        continueButton.SetActive(false);
        //donePopUp.enabled = false;
    }

    void Update()
    {
        if(currentPoints >= pointsToWin){
            // WIN 
            //transform.GetChild(0).gameObject.SetActive(true);
            continueButton.SetActive(true);
            //donePopUp.enabled = true;
        }
    }

    public void AddPoints(){
        currentPoints++;

    }
    }


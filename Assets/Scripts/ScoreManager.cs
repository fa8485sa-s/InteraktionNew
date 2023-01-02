using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public GameObject continueButton;
    public static int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        continueButton.SetActive(false);
        Debug.Log (count);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if(count >= 5){
            continueButton.SetActive(true);
            //count = 0;
        }
    }
}

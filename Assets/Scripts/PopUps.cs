

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUps : MonoBehaviour
{
    //public Image popUp1; //visa om fel en gång 
    //public Image popUp2; //visa om fel två gånger
    public GameObject popUp3; //visa om rätt 

    //public static int counterTries = 0;

    /* public SlotScript counter;
    public SlotScript checkCounter;
    public SlotScript button; */

    // Start is called before the first frame update
    void Start()
    {
        //popUp1.enabled = false;
        //popUp2.enabled = false;
        popUp3.SetActive(false);
        //popUp3.enabled = false;
        
    }

    public void OnMouseDown(){
        //popUp3.enabled = !popUp3.enabled;
        popUp3.SetActive(true);
    }

    /* public void OnMouseDownTwo(){
        popUp2.enabled = !popUp2.enabled;
    }

    public void OnMouseDownThree(){
        popUp1.enabled = !popUp1.enabled;
    } */

    /* public void OnMouseEnter(){
        if(Input.GetMouseButtonDown(0)){
            
            if(counter.counter == 5){
            Debug.Log("testa igen");
            //popUp1.enabled = !image.enabled;
            counterTries++;
            //10 sekunder eller stäng ner med knapp 
            }

            if(counter.counter == 5 && counterTries >= 2){
            Debug.Log("Testa igen");
            //popUp2.enabled = !image.enabled;
            //10 sekunder eller stäng ner med knapp 
            }

            if(checkCounter.checkCounter == 5){
            Debug.Log("Nästa scen");
            popUp3.enabled = true;
            //skicka till nästa scen där roboten säger bra jobbat, och beställer 
            }

        }
    }  */

    
}
 
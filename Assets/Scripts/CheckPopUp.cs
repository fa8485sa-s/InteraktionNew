using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CheckPopUp : MonoBehaviour {  //IDropHandler

        /* public int id;
        public int checkCounter = 0; //static 
        public int counter = 0;      ///static 
        public int counterTries = 0;
        public bool[] checkList = new bool[5];  */
        //public var image; //the image we want to drag in the inspector 

        public Image popUp; //the popup 

        public GameObject continueButton;

        void Start()
    {
        continueButton.SetActive(false);
        popUp.enabled = false;
        //popUp.sprite = image;
        /*for(int i = 0; i < 5; i++){
            checkList[i] = false;
        }*/
    }
}

    /* public void OnDrop(PointerEventData eventData){
        Debug.Log("Item dropped");
       // if (eventData.pointerDrag != null){
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;
            counter++;

        /* for(int i = 0; i < 5; i++){
            if(eventData.pointerDrag.GetComponent<DragAndDrop>().id == id){
                //checkList[i] = true;
                checkCounter++;
            }
        } 
    } */
    

    /* void Update(){
        if(counter == 5){
            Debug.Log("Det funkar");
            continueButton.SetActive(true);
            OnMouseEnter();
        }

    } */

     /* void OnMouseEnter(){
        //PopUps popUp = 
        if(Input.GetMouseButtonDown(0)){
            
            if(counter == 5){
            Debug.Log("testa igen");
            //popUp1.enabled = !image.enabled;
            counterTries++;
            //10 sekunder eller stäng ner med knapp 
            }

            if(counter == 5 && counterTries >= 2){
            Debug.Log("Testa igen");
            //popUp2.enabled = !image.enabled;
            //10 sekunder eller stäng ner med knapp 
            }

            if(checkCounter == 5){
            Debug.Log("Nästa scen");
            popUp.enabled = true;

            //skicka till nästa scen där roboten säger bra jobbat, och beställer 
            }

        }
    }   */





// - - - - - - - - - - - Progress bar - - - - - - - 

           //     eventData.pointerDrag.GetComponent<DragAndDrop>().ResetPosition();
           // }

            
       // }

       /* public int maxHealth = 100;
        public int currentHealth; */

        /* public Progressbar progressBar; */

        //void Start(){
            /* currentHealth = maxHealth;
            progressBar.SetMaxProgress(maxHealth); */
        //}
   

  /*   void Update(){
        FillProgressBar(20);
        
    } */

      //void FillProgressBar(int damage){
        //currentHealth -= damage;
        //progressBar.SetProgressBar(currentHealth);

        //if(eventData.pointerDrag.GetComponent<DragAndDrop>().id == id){
            //if(currentValue == 100){
                //check.GameObject.SetActive(true);
               // Debug.Log("KLart");
                //}else{
                //    currentValue += success;
                //    progressBar.SetProgressBar(currentValue);
            //    }




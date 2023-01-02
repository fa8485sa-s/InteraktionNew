using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class SlotScript : MonoBehaviour, IDropHandler {

    
        public int id;
        public GameObject continueButton;
        public Image image;
        public static int[] checkList = {0,0,0,0,0}; 
        //public WInScript win;
        //public static int checkCounter = 0; //static 


        void Start(){
            continueButton.SetActive(false);
            image.enabled = false;

        }
    

    public void OnDrop(PointerEventData eventData){

        Debug.Log("Item dropped");
        if (eventData.pointerDrag != null){
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;
        }
            //Här vill jag att knappen ska visas när alla är rätt och så tas man vidare..
            //men det funkar inte om man tar bort ordet från rutan 
            //innan dess kan man få hjälp av roboten genom olika klick , var < 3 ledtrådar varannat klick 
        if(eventData.pointerDrag.GetComponent<DragAndDrop>().id == id){
           Debug.Log("Ett rätt");
           checkList[id] = 1;
        }else{
            checkList[id] = 0;
        }

        /* for(int i = 0; i < 5; i++){
            if(checkList[i] == 1){
                checkCounter++;
                Debug.Log("Rätt: " + checkList[i]);
            }else{
                Debug.Log("Fel: " + checkList[i]);

            }
        } */

    } 

       void Update(){
        int checkCounter = 0;

        for(int i = 0; i < 5; i++){
            if(checkList[i] == 1){
                checkCounter++;
                Debug.Log("Rätt: " + checkList[i]);
            }else{
                Debug.Log("Fel: " + checkList[i]);

            }
        }

    if(checkCounter == 5){
            continueButton.SetActive(true);
            image.enabled = true;
        }
    }
}


// - - - - - - - - - Tidigare testat olika saker - - - - - - - - -

            //lägger till noll om dragit bort nån annanstans på spelplanen än slot
        /* for(int i = 0; i < 5; i++){
            if(newId != i){
               idCounter++;
               Debug.Log("idcounter ökar");
            } 
        } */
            /* if(idCounter == 5){
                checkList[newId] = 0;
                Debug.Log("checklist:" + checkList[newId]);
            } */

            /* if(!item){
            DragAndDrop.itemBeingDragged.transform.SetParent (transform);
            ExecuteEvents.ExecuteHierarchy<IHasChanged>(gameObject, null, (x,y) => x.HasChanged());

         */
        


    //gör detta i en annan klass winscript !!!!!!!!!!!!!!
    /* void Update(){

        if(counter == 5){
            continueButton.SetActive(true);
        }

        for(int i = 0; i<5; i++){
            if(checkList[i] == 1){
                checkCounter++;
                Debug.Log("Rätt: " + checkList[i]);
            }else{
                Debug.Log("Fel: " + checkList[i]);
            }
        }

        //kolla igenom en lista med 1or för rätt, 0or för fel 
       // if(checkCounter == 5){
        //    Debug.Log("Alla rätt!");
            
       // }

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
            //popUp.enabled = true;
            }
        }
    }  */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class AnotherScript : MonoBehaviour, IDropHandler {

    
        public int id;
        public GameObject continueButton;
        public Image image;
        public static int[] AnotherList = {0,0,0,0,0,0,0,0,0}; 
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
           AnotherList[id] = 1;
        }else{
            AnotherList[id] = 0;
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
            if(AnotherList[i] == 1){
                checkCounter++;
                Debug.Log("Rätt: " + AnotherList[i]);
            }else{
                Debug.Log("Fel: " + AnotherList[i]);

            }
        }

    if(checkCounter == 5){
            continueButton.SetActive(true);
            image.enabled = true;
        }
    }
}


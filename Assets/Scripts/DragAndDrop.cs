using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{

    private RectTransform rectTrans;
    public Canvas myCanvas;
    private CanvasGroup canvasGroup;
    public int id;

    void Start()
    {
        rectTrans = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        
    }

    
   public void OnBeginDrag(PointerEventData eventData)
   {

    Debug.Log("BeginDrag");
    canvasGroup.blocksRaycasts = false; //object is not hit 
   }

   public void OnDrag(PointerEventData eventData)
   {
        rectTrans.anchoredPosition += eventData.delta / myCanvas.scaleFactor;
   }
   

   public void OnEndDrag(PointerEventData eventData)
   {
    Debug.Log("EndDrag");
    canvasGroup.blocksRaycasts = true; //object is hit 
    
   }

   public void OnPointerDown(PointerEventData eventData)
   {
    Debug.Log("Click");
   }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUp : MonoBehaviour
{
    public Image image;
    
    //public Text text;
    public Button button;

    // Start is called before the first frame update
    void Start()
    {
        image.enabled = false;
        //displayText().text = "";
        button.onClick.AddListener(OnMouseDown);
        
    }

    //public void DisplayText(){
        //displayText().text = "BBla anl";
    //}

    public void OnMouseDown(){
        image.enabled = !image.enabled;
        //DisplayText();
    }

}

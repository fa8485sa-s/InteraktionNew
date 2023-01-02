using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowImage : MonoBehaviour{


  public GameObject image;

  void Start(){
    image.SetActive(true);
    StartCoroutine (Test());

  }

  IEnumerator Test(){
    yield return new WaitForSeconds(5);
    image.SetActive(false);
  }
}
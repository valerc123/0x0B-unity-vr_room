using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class passcodeparticle : MonoBehaviour
{
    public InputField inputField;
    public GameObject particlesystem;
    public GameObject canvas;

   
    public void checkInput(){
        if (inputField.text == "1010"){
            Debug.Log("accepted");
            particlesystem.SetActive(true);
            canvas.SetActive(false);
        }
    }
}

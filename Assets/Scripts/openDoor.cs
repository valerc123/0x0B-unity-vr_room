using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour
{
    public GameObject canvas;
    public bool switchAnimation = false;
    void Start(){
        canvas.SetActive(false);
    }
    public void activeAnimation(){
        canvas.SetActive(switchAnimation);
        switchAnimation = !switchAnimation;
    }
}

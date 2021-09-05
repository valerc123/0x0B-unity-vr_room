using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour
{
    private Animator animator;
    public bool switchAnimation = true;
   
    void Start(){
        animator = GetComponent<Animator>();
        animator.SetBool("character_nearby", false);
    }
    public void activeAnimation(){
        animator.SetBool("character_nearby", switchAnimation);
        switchAnimation = !switchAnimation;
    }
}

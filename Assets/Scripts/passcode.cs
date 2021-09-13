using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class passcode : MonoBehaviour
{
    public InputField inputField;
    private Animator animator;
    public bool switchAnimation = true;
    public GameObject door;
   
    void Start(){
        animator = door.GetComponent<Animator>();
        animator.SetBool("character_nearby", false);
    }
   
    public void checkInput(){
        if (inputField.text == "1010"){
            Debug.Log("accepted");
            animator.SetBool("character_nearby", switchAnimation);
            switchAnimation = !switchAnimation;
            gameObject.SetActive(false);
        }
    }
}

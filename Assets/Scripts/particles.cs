using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particles : MonoBehaviour
{
    public GameObject canvas;
    private bool switchParticle = true;


    void Start (){
        canvas.SetActive(false);

    }
    public void ActivateParticle()
    {
        canvas.SetActive(switchParticle);
        switchParticle = !switchParticle;
        Debug.Log("entro");
    }
}

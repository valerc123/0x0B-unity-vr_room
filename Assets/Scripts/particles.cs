using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particles : MonoBehaviour
{
    public GameObject particlesSystem;
    private bool switchParticle = true;

    public void ActivateParticle()
    {
        particlesSystem.SetActive(switchParticle);
        switchParticle = !switchParticle;
        Debug.Log("entro");
    }
}

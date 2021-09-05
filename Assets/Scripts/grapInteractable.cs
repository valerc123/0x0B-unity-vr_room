using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class grapInteractable : MonoBehaviour
{
    public Material hover = null;
    public Material Onhover = null;
    private MeshRenderer meshRenderer = null;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material = Onhover;
    }

    public void setColorOnhover()
    {
        
            meshRenderer.material = Onhover;
        
    }
    public void setColorHover()
    {
        
            meshRenderer.material = hover;
       
    }
}

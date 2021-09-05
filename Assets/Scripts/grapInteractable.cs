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

    public void setColorOnhover(Collider other)
    {
        meshRenderer.material = Onhover;
    }
    public void setColorHover(Collider other)
    {
        meshRenderer.material = hover;
    }
}

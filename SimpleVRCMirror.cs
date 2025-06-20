using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class MirrorToggle : UdonSharpBehaviour
{
    public GameObject mirrorObject;

    public override void Interact()
    {
        if (mirrorObject != null)
        {
            mirrorObject.SetActive(!mirrorObject.activeSelf);
        }
    }
}


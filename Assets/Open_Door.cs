using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Open_Door : MonoBehaviour
{ 
    private bool isOpen = false;
    public Transform door1;
    public Transform door2;
    private XRGrabInteractable grabInteractable;

    void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.onActivate.AddListener(OnButtonPress);
    }

    public void OnButtonPress(XRBaseInteractor interactor)
    {
        if (isOpen)
        {
            CloseDoors();
        }
        else
        {
            OpenDoors();
        }

        isOpen = !isOpen;
    }

    private void OpenDoors()
    {
        door1.localPosition += new Vector3(1f, 0f, 0f);
        door2.localPosition += new Vector3(-1f, 0f, 0f);
    }

    void CloseDoors()
    {
        door1.localPosition -= new Vector3(1f, 0f, 0f);
        door2.localPosition -= new Vector3(-1f, 0f, 0f);
    }
}


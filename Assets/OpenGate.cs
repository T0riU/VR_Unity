using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class OpenGate : MonoBehaviour
{
    private bool isOpen = false;
    public Transform kapi1;
    public Transform kapi2;
    private Quaternion originalRotationKapi1;
    private Quaternion originalRotationKapi2;

    private XRGrabInteractable grabInteractable;

    void Start()
    {
        originalRotationKapi1 = kapi1.rotation;
        originalRotationKapi2 = kapi2.rotation;

        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.onActivate.AddListener(OnButtonPress);
    }

    public void OnButtonPress(XRBaseInteractor interactor)
    {
        if (isOpen)
        {
            CloseGates();
        }
        else
        {
            OpenGates();
        }

        isOpen = !isOpen;
    }

    private void OpenGates()
    {
        kapi1.localPosition += new Vector3(-1f, 0f, -1f);
        kapi1.localRotation *= Quaternion.Euler(0f, 90f, 0f);
        kapi2.localPosition += new Vector3(1f, 0f, -1f);
        kapi2.localRotation *= Quaternion.Euler(0f, -90f, 0f);
    }

    void CloseGates()
    {
        kapi1.localPosition -= new Vector3(-1f, 0f, -1f);
        kapi1.localRotation *= Quaternion.Euler(0f, -90f, 0f);
        kapi2.localPosition -= new Vector3(1f, 0f, -1f);
        kapi2.localRotation *= Quaternion.Euler(0f, 90f, 0f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.XR.Interaction.Toolkit;

public class SelectMoveType : MonoBehaviour
{
    public UnityEngine.UIElements.Slider slider;
    public ActionBasedContinuousMoveProvider move;
    public TeleportationProvider teleport;
    public void SetTypeIndex(int index)
    {
        if (index == 1)
        {
            teleport.enabled = false;
            move.enabled = true;
        } else if (index == 0)
        {
            teleport.enabled = true;
            move.enabled = false;
        }
    }
}

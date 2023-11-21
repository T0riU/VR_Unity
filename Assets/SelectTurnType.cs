using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.XR.Interaction.Toolkit;

public class SelectTurnType : MonoBehaviour
{
    public UnityEngine.UIElements.Slider slider;
    public ActionBasedSnapTurnProvider snapTurn;
    public ActionBasedContinuousTurnProvider continuousTurn;
    public UnityEngine.UI.Slider sl;

    public void SetTypeIndex(int index)
    {
        if (index == 0)
        {
            snapTurn.enabled = false;
            continuousTurn.enabled = true;
            sl.interactable = false;
        } else if (index == 1)
        {
            snapTurn.enabled = true;
            continuousTurn.enabled = false;
            sl.interactable = true;
        }
    }
}

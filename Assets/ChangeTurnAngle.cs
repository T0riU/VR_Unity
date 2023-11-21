using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ChangeTurnAngle : MonoBehaviour
{
    public ActionBasedSnapTurnProvider snapTurn;


    public void SetAngle(float ang)
    {
        snapTurn.turnAmount = ang;
    }
}

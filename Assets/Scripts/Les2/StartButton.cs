using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour, IClick
{
    public void CLickOnButton()
    {
        FindObjectOfType<Portal>()?.transform.GetChild(1);
    }
}

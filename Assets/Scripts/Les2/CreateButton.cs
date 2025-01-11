using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateButton : MonoBehaviour, IClick
{
    [SerializeField]
    public GameObject portal;

    public void CLickOnButton()
    {
        Instantiate(portal);
    }
}

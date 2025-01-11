using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateButton : MonoBehaviour, IClick
{
    [SerializeField]
    public GameObject portal;
    [SerializeField]
    public Vector3 pos;

    public void CLickOnButton()
    {
        Instantiate(portal, pos, Quaternion.identity);
    }
}

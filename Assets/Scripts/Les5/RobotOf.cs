using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotOf : MonoBehaviour, IRobot, IWaiter
{
    [SerializeField] protected GameObject coffee;
    public virtual void Bring()
    {
        Debug.Log("Cof");
        Instantiate(coffee, transform.position + new Vector3(0, 1f, -1f), Quaternion.identity);
    }

    public void Greating()
    {
        Debug.Log("uwu");
    }

    public virtual void Use()
    {
        Debug.Log("www");
    }
}

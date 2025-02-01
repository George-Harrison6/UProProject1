using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotOfSmall : RobotOf
{
    [SerializeField] private GameObject water;

    public void Bring(int index)
    {
        if(index == 0)
        {
            Debug.Log("(!)w(!) wat");
            Instantiate(water, transform.position + new Vector3(0, 1f, -1f), Quaternion.identity);
        }

        if(index == 1)
        {
            Debug.Log("(!)w(!) cof");
            Instantiate(coffee, transform.position + new Vector3(0, 1f, -1f), Quaternion.identity);
        }
    }
    public override void Bring()
    {
        StartCoroutine(Choose());
    }

    public override void Use()
    {
        Debug.Log("water or coffee, put 5 or 4");
    }

    IEnumerator Choose()
    {
        bool isStop = true;

        while (isStop)
        {
            if (Input.GetKey(KeyCode.Alpha4))
            {
                Bring(1);

                isStop = false;
            }
            
            if (Input.GetKey(KeyCode.Alpha5))
            {
                Bring(0);

                isStop = false;
            }
            yield return new WaitForSeconds(0.02f);
        }
    }
}

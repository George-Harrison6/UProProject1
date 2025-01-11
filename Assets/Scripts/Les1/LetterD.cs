using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LetterD : MonoBehaviour, ILetter
{
    public void CLick()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(transform.DOJump(new Vector3(0, 0, 0), 1, 1, 1));
        sequence.Join(transform.DORotate(new Vector3(0, 360, 0), 1, RotateMode.FastBeyond360));


        sequence.Play();
    }
}

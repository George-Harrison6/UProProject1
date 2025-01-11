using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LetterE : MonoBehaviour, ILetter
{
    private Renderer rend;
    private Color currentColor;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        currentColor = rend.material.color;
    }
    public void CLick()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(transform.DOJump(new Vector3(0, 0, 0), 1, 1, 1));
        sequence.Join(transform.DORotate(new Vector3(0, 360, 0), 1, RotateMode.FastBeyond360));

        sequence.Append(rend.material.DOColor(Random.ColorHSV(), 1f));
        sequence.AppendInterval(2);
        sequence.Append(rend.material.DOColor(currentColor, 1f));


        sequence.Play();
    }
}

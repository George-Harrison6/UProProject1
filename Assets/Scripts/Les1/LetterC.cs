using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LetterC : MonoBehaviour, ILetter
{
    private Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
    }
    public void CLick()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(rend.material.DOFade(0, 1f));
        sequence.AppendInterval(2);
        sequence.Append(rend.material.DOFade(1, 1f));

        sequence.Play();
    }
}

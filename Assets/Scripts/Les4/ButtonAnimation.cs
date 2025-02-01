using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ButtonAnimation : MonoBehaviour
{
    void Start()
    {
        Sequence seq = DOTween.Sequence();

        seq.Append(GetComponent<RectTransform>().DOScale(new Vector3(0.8f, 0.8f, 0.8f), 1f));
        seq.Append(GetComponent<RectTransform>().DOScale(new Vector3(1f, 1f, 1f),1f));

        seq.SetLoops(-1);
    }
}

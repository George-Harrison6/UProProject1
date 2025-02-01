using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PushButton : ObjectPanelInfo
{
    [SerializeField]
    private TMP_Text textButton;
    [SerializeField]
    private string strTextButton;
    [SerializeField]
    private Button button;


    private void Awake()
    {
        SetText();
    }

    public override void SetText()
    {
        base.SetText();

        textButton.text = strTextButton;

        button.onClick.AddListener(() =>
        {
            Debug.Log("Level Up");
        });
    }
}

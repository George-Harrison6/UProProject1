using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ObjectPanelInfo : MonoBehaviour
{
    [SerializeField]
    private Image imageObject;
    [SerializeField]
    private TMP_Text textObject;
    [SerializeField]
    private Sprite spriteObject;
    [SerializeField]
    private string nameObject;
    [SerializeField]
    private TMP_Text button;
    [SerializeField]
    private string strTextButton;
    

    private void Awake()
    {
        imageObject.sprite = spriteObject;
        textObject.text = nameObject;
        button.text = strTextButton;
    }
}
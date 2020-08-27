using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITextManager : SingletonMonoBehaviour<UITextManager>
{
    [SerializeField] private Text touchNumText;

    private int touchNum;

    public void AddTouchNum()
    {
        touchNum++;
        touchNumText.text = "TouchNum: " + touchNum.ToString();
    }
}

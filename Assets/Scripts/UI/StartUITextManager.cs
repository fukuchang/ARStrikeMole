using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartUITextManager : SingletonMonoBehaviour<StartUITextManager>
{
    [SerializeField] private GameObject TitleObject;
    [SerializeField] private GameObject AnnouceObject;
    private Text annouceText;

    private void Start()
    {
        annouceText = AnnouceObject.GetComponentInChildren<Text>();
    }

    public void ChangeAnnouceText(string _text)
    {
        annouceText.text = _text;
    }
}

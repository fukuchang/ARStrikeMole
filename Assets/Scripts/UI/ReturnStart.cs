using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReturnStart : MonoBehaviour
{
    [SerializeField] private Button returnStartButton;

    // Start is called before the first frame update
    void Start()
    {
        returnStartButton.onClick.AddListener(() => CommonScript.SceneManager.GameReturnPhase());
    }
}

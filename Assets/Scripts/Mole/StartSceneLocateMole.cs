using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class StartSceneLocateMole : LocateMole
{
    private bool isGenerate = false;

    // Start is called before the first frame update
    void Start()
    {
        raycastManager = GetComponent<ARRaycastManager>();
        isLocate = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGenerate)
        {
            StartUITextManager.Instance.ChangeAnnouceText("もぐらをタッチしてスタート!");
            return;
        }

        if (raycastManager.Raycast(centerPos, raycastHits, TrackableType.All) && isLocate)
        {
            isLocate = false;
            isGenerate = true;
            StartCoroutine(GenerateMoleCoroutine(mole, raycastHits[0].pose, 0f));
        }
        else
        {
            StartUITextManager.Instance.ChangeAnnouceText("画面を固定してください");
        }
    }
}

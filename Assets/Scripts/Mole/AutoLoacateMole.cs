using System.Collections;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class AutoLoacateMole : LocateMole
{
    // Start is called before the first frame update
    void Start()
    {
        raycastManager = GetComponent<ARRaycastManager>();
        StartCoroutine(LocateMole());
    }

    // Update is called once per frame
    void Update()
    {
        if(raycastManager.Raycast(centerPos, raycastHits, TrackableType.All) && isLocate)
        {
            isLocate = false;
            StartCoroutine(LocateMole());
            StartCoroutine(GenerateMoleCoroutine(mole, raycastHits[0].pose, 2.0f));
        }
    }

    private IEnumerator LocateMole()
    {
        yield return new WaitForSeconds(2.0f);
        isLocate = true;
    }
}

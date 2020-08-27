using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class AutoLoacateMole : MonoBehaviour
{
    [SerializeField] GameObject mole;
    private ARRaycastManager raycastManager;
    private List<ARRaycastHit> raycastHits = new List<ARRaycastHit>();
    private Vector3 centerPos;

    private bool isLocate = false;

    // Start is called before the first frame update
    void Start()
    {
        raycastManager = GetComponent<ARRaycastManager>();
        centerPos = new Vector3(Screen.width / 2, Screen.height / 2, 0);
        StartCoroutine(LocateMole());
    }

    // Update is called once per frame
    void Update()
    {
        if(raycastManager.Raycast(centerPos, raycastHits, TrackableType.All) && isLocate)
        {
            isLocate = false;
            StartCoroutine(LocateMole());
            StartCoroutine(GenerateMole(mole, raycastHits[0].pose.position, raycastHits[0].pose.rotation));
        }
    }

    private IEnumerator LocateMole()
    {
        yield return new WaitForSeconds(2.0f);
        isLocate = true;
    }

    private IEnumerator GenerateMole(GameObject obj, Vector3 pos, Quaternion rot)
    {
        yield return new WaitForSeconds(2.0f);
        Instantiate(obj, pos, rot);
    }
}

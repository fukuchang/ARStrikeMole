using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARLocateCube : MonoBehaviour
{
    [SerializeField] GameObject cube;
    private ARRaycastManager raycastManager;
    private List<ARRaycastHit> raycastHits = new List<ARRaycastHit>();

    // Start is called before the first frame update
    void Start()
    {
        raycastManager = GetComponent<ARRaycastManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase != TouchPhase.Ended)
            {
                return;
            }
            if (raycastManager.Raycast(touch.position, raycastHits, TrackableType.All))
            {
                Instantiate(cube, raycastHits[0].pose.position, raycastHits[0].pose.rotation);
            }
        }
    }
}

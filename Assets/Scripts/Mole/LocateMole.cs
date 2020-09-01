using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

[RequireComponent(typeof(ARRaycastManager))]
public class LocateMole : MonoBehaviour
{
    [SerializeField] protected GameObject mole;
    protected ARRaycastManager raycastManager;
    protected List<ARRaycastHit> raycastHits = new List<ARRaycastHit>();
    protected Vector3 centerPos = new Vector3(Screen.width / 2, Screen.height / 2, 0);

    protected bool isLocate = false;

    public virtual IEnumerator GenerateMoleCoroutine(GameObject obj, Pose pose, float time)
    {
        yield return new WaitForSeconds(time);
        Instantiate(obj, pose.position, pose.rotation);
    }
}

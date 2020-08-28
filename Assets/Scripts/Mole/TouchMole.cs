using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public abstract class TouchMole : MonoBehaviour
{
    private Camera arCamera;

    // Start is called before the first frame update
    void Start()
    {
        arCamera = GetComponent<Camera>();
    }

    protected void JudgeTouch()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            RaycastHit hit;
            Ray ray = arCamera.ScreenPointToRay(touch.position);
            if (touch.phase != TouchPhase.Ended)
            {
                return;
            }
            if (Physics.Raycast(ray, out hit))
            {
                RaycastHitJudge(hit);
            }
        }
    }

    public virtual void RaycastHitJudge(RaycastHit hit)
    {
        if (hit.collider.CompareTag("MoleHead"))
        {
            Destroy(hit.collider.transform.parent.gameObject);
            UITextManager.Instance.AddTouchNum();
        }
    }
}

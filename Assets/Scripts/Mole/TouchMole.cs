using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMole : MonoBehaviour
{
    private Camera arCamera;
    private int touchNum;

    // Start is called before the first frame update
    void Start()
    {
        arCamera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
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
                if (hit.collider.CompareTag("MoleHead"))
                {
                    Destroy(hit.collider.transform.parent.gameObject);
                    UITextManager.Instance.AddTouchNum();
                }
            }
        }
    }

}

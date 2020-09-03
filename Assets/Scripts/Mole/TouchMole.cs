using UnityEngine;

[RequireComponent(typeof(Camera))]
public abstract class TouchMole : MonoBehaviour
{
    private Camera arCamera;
    private GameObject explosion;
    private GameObject hummerSound;

    // Start is called before the first frame update
    void Start()
    {
        arCamera = GetComponent<Camera>();
        explosion = Resources.Load("Prefab/Effects/Explosion") as GameObject;
        hummerSound = Resources.Load("Prefab/SEObject/HummerSound") as GameObject;
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
                if (hit.collider.CompareTag("MoleHead"))
                {
                    RaycastHitJudge(hit);
                }
            }
        }
    }

    private void RaycastHitJudge(RaycastHit hit)
    {
        Instantiate(explosion, hit.transform.position, Quaternion.identity);
        Instantiate(hummerSound, hit.transform.position, Quaternion.identity);
        Destroy(hit.collider.transform.parent.gameObject);
        OriginalFunction(hit.collider.transform.parent.gameObject.tag);
    }

    public abstract void OriginalFunction(string tag);
}

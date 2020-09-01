using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2.0f);
    }
}

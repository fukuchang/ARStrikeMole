using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 molePos = gameObject.transform.position;
        var animator = GetComponent<Animator>();
    }

    public void DeleteMole()
    {
        Destroy(gameObject);
    }
}

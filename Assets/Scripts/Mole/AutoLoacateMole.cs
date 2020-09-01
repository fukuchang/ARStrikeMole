using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class AutoLoacateMole : LocateMole
{
    [SerializeField] private Text recogText;

    // Start is called before the first frame update
    void Start()
    {
        raycastManager = GetComponent<ARRaycastManager>();
        isLocate = true;
    }

    // Update is called once per frame
    void Update()
    {
        var vec = RandomPos();
        if (raycastManager.Raycast(RandomPos(), raycastHits, TrackableType.All) && (isLocate || SpawnManager.IsExtendLocate))
        {
            recogText.text = vec.x.ToString();
            if (isLocate) isLocate = false;
            if (SpawnManager.IsExtendLocate) SpawnManager.IsExtendLocate = false;

            StartCoroutine(LocateMole());
            StartCoroutine(GenerateMoleCoroutine(mole, raycastHits[0].pose, 2.0f));
        }
    }

    private IEnumerator LocateMole()
    {
        yield return new WaitForSeconds(2f);
        isLocate = true;
    }

    private Vector3 RandomPos()
    {
        var range = Random.Range(-150f, 0f);

        var rand = Random.Range(0, 10);
        switch (rand)
        {
            case 0:
            case 1:
                return new Vector3(0, Screen.height / 2 + range, 0);
            case 2:
            case 3:
            case 4:
            case 5:
            case 6:
            case 7:
                return new Vector3(Screen.width, Screen.height / 2 + range, 0);
            case 8:
            case 9:
                return centerPos;
            default:
                return centerPos;
        }
    }
}

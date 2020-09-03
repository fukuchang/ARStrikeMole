using System.Collections;
using UnityEngine;

public class InGameTouchMole : TouchMole
{
    public override void OriginalFunction(string tag)
    {
        // StartCoroutine(SpawnLatancy());
        switch (tag)
        {
            case "Mole":
                UITextManager.Instance.AddTouchNum(1);
                break;
            case "GoldMole":
                UITextManager.Instance.AddTouchNum(3);
                break;
            default:
                UITextManager.Instance.AddTouchNum(1);
                break;
        }
    }

    private IEnumerator SpawnLatancy()
    {
        yield return new WaitForSeconds(1f);
        SpawnManager.IsExtendLocate = true;
    }

    private void Update()
    {
        JudgeTouch();
    }
}

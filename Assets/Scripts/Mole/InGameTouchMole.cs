using System.Collections;
using UnityEngine;

public class InGameTouchMole : TouchMole
{
    public override void OriginalFunction()
    {
        StartCoroutine(SpawnLatancy());
        UITextManager.Instance.AddTouchNum();
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

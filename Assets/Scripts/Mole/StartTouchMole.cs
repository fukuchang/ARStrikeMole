using System.Collections;
using UnityEngine;

public class StartTouchMole : TouchMole
{
    public override void OriginalFunction()
    {
        StartCoroutine(StartLatancy());
    }

    private void Update()
    {
        JudgeTouch();
    }

    private IEnumerator StartLatancy()
    {
        yield return new WaitForSeconds(1.0f);
        CommonScript.SceneManager.GameStartPhase();
    }
}

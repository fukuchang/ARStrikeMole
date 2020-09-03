using System.Collections;
using UnityEngine;

public class StartTouchMole : TouchMole
{
    public override void OriginalFunction(string tag)
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
        CommonScript.ScoreManager.ResetScore();
        CommonScript.SceneManager.GameStartPhase();
    }
}

using UnityEngine;

public class StartTouchMole : TouchMole
{
    public override void OriginalFunction()
    {
        CommonScript.SceneManager.GameStartPhase();
    }

    private void Update()
    {
        JudgeTouch();
    }
}

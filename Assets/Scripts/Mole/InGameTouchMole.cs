public class InGameTouchMole : TouchMole
{
    public override void OriginalFunction()
    {
        UITextManager.Instance.AddTouchNum();
    }

    private void Update()
    {
        JudgeTouch();
    }
}

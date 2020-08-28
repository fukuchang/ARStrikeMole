using UnityEngine;

public class StartTouchMole : TouchMole
{
    public override void RaycastHitJudge(RaycastHit hit)
    {
        Destroy(hit.collider.transform.parent.gameObject);
        CommonScript.SceneManager.GameStartPhase();
    }

    private void Update()
    {
        JudgeTouch();
    }
}

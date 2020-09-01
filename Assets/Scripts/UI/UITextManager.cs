using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UITextManager : SingletonMonoBehaviour<UITextManager>
{
    [SerializeField] private Text touchNumText;
    [SerializeField] private Text timeLimitText;

    private int touchNum;
    [SerializeField] private int timeLimit;
    private int time;

    private void Start()
    {
        time = timeLimit;
        StartCoroutine(StartCountDown());
    }

    public void AddTouchNum()
    {
        touchNum++;
        touchNumText.text = "TouchNum: " + touchNum.ToString();
    }

    private IEnumerator StartCountDown()
    {
        yield return new WaitForSeconds(1);
        time--;
        timeLimitText.text = "TimeLimit:" + time.ToString();
        if (time > 0)
        {
            StartCoroutine(StartCountDown());
        }
        else
        {
            CommonScript.SceneManager.GameOverPhase();
            yield return null;
        }
    }

}

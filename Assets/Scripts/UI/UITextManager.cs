using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UITextManager : SingletonMonoBehaviour<UITextManager>
{
    [SerializeField] private TextMeshProUGUI touchNumText;
    [SerializeField] private TextMeshProUGUI timeLimitText;

    private int touchNum;
    [SerializeField] private int timeLimit;
    private int time;

    private void Start()
    {
        time = timeLimit;
        StartCoroutine(StartCountDown());
    }

    private void Update()
    {
        if (time < 10f)
        {
            timeLimitText.faceColor = new Color32(253, 49, 60, 255);
        }
    }

    public void AddTouchNum(int num)
    {
        touchNum += num;
        touchNumText.text = "Score: " + touchNum.ToString();
    }

    private IEnumerator StartCountDown()
    {
        yield return new WaitForSeconds(1);
        time--;
        timeLimitText.text = "Time:" + time.ToString();
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

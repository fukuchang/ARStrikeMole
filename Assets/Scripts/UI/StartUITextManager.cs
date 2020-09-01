using UnityEngine;
using UnityEngine.UI;

public class StartUITextManager : SingletonMonoBehaviour<StartUITextManager>
{
    [SerializeField] private GameObject TitleObject;
    [SerializeField] private GameObject AnnouceObject;
    [SerializeField] private GameObject RestartObject;
    private Text annouceText;
    private Button restartButton;
    private GameObject mole;
    public bool isGenerate { get; private set; }

    private void Start()
    {
        annouceText = AnnouceObject.GetComponentInChildren<Text>();
        restartButton = RestartObject.GetComponentInChildren<Button>();
        restartButton.onClick.AddListener(() => Restart());
    }

    public void ChangeAnnouceText(string _text)
    {
        annouceText.text = _text;
    }

    private void Restart()
    {
        Destroy(mole);
        isGenerate = false;
        RestartObject.SetActive(false);
    }

    public void VisibleRestart(GameObject _mole)
    {
        mole = _mole;
        isGenerate = true;
        RestartObject.SetActive(true);
    }
}

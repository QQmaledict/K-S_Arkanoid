using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text  _score;
    [SerializeField] private TMP_Text _level;
    [SerializeField] private GameObject _pausePanel;
    [SerializeField] private GameObject _panelWin;
    [SerializeField] private Sprite[] _pause;
    [SerializeField] private GameObject[] _scenes;
    [SerializeField] private Image _img;

    public int Score;
    public int Length;

    private void Awake()
    {
        int l = PlayerPrefs.GetInt("Level");
        if (l == 0)
        {
            l += 1;
            PlayerPrefs.SetInt("Level", l);
        }
        PlayerPrefs.SetInt("Level", l);
        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            Instantiate(_scenes[l-1]);
        }
    }
    private void Start()
    {
        if (_level !=null)
        {
            _level.text = "Уровень " + PlayerPrefs.GetInt("Level").ToString();
        }
        Application.targetFrameRate = 120;
        Time.timeScale = 1f;
        if (_score != null)
        {
            UpdateScore();
        }
    }

    public void Pause()
    {
        _img.sprite = _img.sprite == _pause[0] ? _img.sprite = _pause[1] : _img.sprite = _pause[0];
        Time.timeScale = Time.timeScale == 0 ? 1f:0f;
        _pausePanel.SetActive(!_pausePanel.activeSelf);
    }

    public void UpdateScore()
    {
       // GameObject[] obj = GameObject.FindGameObjectsWithTag("Plitka");
        _score.text = Score.ToString() + "/" + Length.ToString();
        if (Score >= Length)
        {
            _panelWin.SetActive(true);
            int l = PlayerPrefs.GetInt("Level");
            PlayerPrefs.SetInt("Level",l+1);
            Time.timeScale = 0f;
        }
    }
}

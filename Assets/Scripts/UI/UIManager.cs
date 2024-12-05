using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text _score;
    [SerializeField] private GameObject _pausePanel;
    [SerializeField] private GameObject _panelWin;

    public int Score;
    public int Length;

    private void Start()
    {
        Time.timeScale = 1f;
        if (_score != null)
        {
            UpdateScore();
        }
    }

    public void Pause()
    {
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
            Time.timeScale = 0f;
        }
    }
}

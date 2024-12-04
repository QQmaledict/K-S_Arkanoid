using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text _score;
    [SerializeField] private GameObject _pausePanel;

    public int Score;
    public int Length;

    private void Start()
    {
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
    }
}

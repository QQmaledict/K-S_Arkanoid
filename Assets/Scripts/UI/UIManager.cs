using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text _score;

    public int Score;
    public int Length;

    private void Start()
    {
        if (_score != null)
        {
            UpdateScore();
        }
    }
    public void UpdateScore()
    {
       // GameObject[] obj = GameObject.FindGameObjectsWithTag("Plitka");
        _score.text = Score.ToString() + "/" + Length.ToString();
    }
}

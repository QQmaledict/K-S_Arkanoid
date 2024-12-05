using UnityEngine;

public class TestBalls : MonoBehaviour
{
    public static int ballsCount;
    [SerializeField] private GameObject _plita;
    [SerializeField] private GameObject _panelLose;

    private void Start()
    {
        ballsCount = 0;
        _panelLose.SetActive(false);
    }

    private void Update()
    {
        if (TestBalls.ballsCount == -1)
        {
            _plita.SetActive(false);
            _panelLose.SetActive(true);
        }
    }
}

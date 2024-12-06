using UnityEngine;

public class TestBalls : MonoBehaviour
{
    public static int ballsCount;
    [SerializeField] private GameObject _plita;
    [SerializeField] private GameObject _panelLose;
    [SerializeField] private Rigidbody2D _startBall;

    private void Start()
    {
        ballsCount = 0;
        _panelLose.SetActive(false);

        Vector2 direction = new Vector2(3f, 3f);
        _startBall.AddForce(direction, ForceMode2D.Impulse);
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

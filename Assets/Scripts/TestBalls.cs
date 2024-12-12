using UnityEngine;
using System.Collections;

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
        StartCoroutine(start());
    }

    private void Update()
    {
        if (TestBalls.ballsCount == -1)
        {
            _plita.SetActive(false);
            _panelLose.SetActive(true);
        }
    }

    private IEnumerator start()
    {
        yield return new WaitForSeconds(1f);
        Vector2 direction = new Vector2(3f, 3f);
        _startBall.AddForce(direction, ForceMode2D.Impulse);
    }  
}

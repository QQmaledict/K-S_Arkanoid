using UnityEngine;

public class Plitka : MonoBehaviour
{
    [SerializeField] private GameObject _destroyEfect;
    [SerializeField] private BonusAbs[] _bonus;


    private void Awake()
    {
        GameObject manager = GameObject.FindGameObjectWithTag("UIManager");
        manager.GetComponent<UIManager>().Length += 1;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerMove>())
        {
            GameObject manager = GameObject.FindGameObjectWithTag("UIManager");

            manager.GetComponent<UIManager>().Score += 1;
            manager.GetComponent<UIManager>().UpdateScore();

            GameObject newEect = Instantiate(_destroyEfect,transform.position,Quaternion.identity);

            int i = Random.Range(1,11);

            if (i == 10)
            {
                int r = Random.Range(0, _bonus.Length);
                _bonus[r].Process();
            }

            Destroy(newEect,1.1f);
            Destroy(gameObject);
        }
    }
}

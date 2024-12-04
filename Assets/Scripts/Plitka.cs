using UnityEngine;

public class Plitka : MonoBehaviour
{
    [SerializeField] private GameObject _destroyEfect;

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

            Destroy(newEect,1.1f);
            Destroy(gameObject);
        }
    }
}

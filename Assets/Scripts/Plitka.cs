using UnityEngine;

public class Plitka : MonoBehaviour
{
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
            Destroy(gameObject);
        }
    }
}

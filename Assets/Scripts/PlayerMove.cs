using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent (typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour
{
    [SerializeField]private Rigidbody2D _rb;
    [SerializeField]private GameObject _restartPanel;
    [SerializeField]private GameObject _plita;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        Vector2 direction = new Vector2(6.5f,5f);
        _rb.AddForce(direction,ForceMode2D.Impulse);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Respawn")
        {
            _restartPanel.SetActive(true);
            _plita.SetActive(false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            if (_rb.velocity.y <0.5f && _rb.velocity.y > -0.5f)
            {
                int i = Random.Range(0,2);
                i = i == 0 ? -5 : 5;
                Vector2 direction = new Vector2(0, i*0.3f);
                _rb.AddForce(direction, ForceMode2D.Impulse);
            }
        }
    }
}

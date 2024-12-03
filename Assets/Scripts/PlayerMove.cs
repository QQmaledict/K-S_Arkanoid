using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent (typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour
{
    [SerializeField]private Rigidbody2D _rb;
    void Start()
    {
        Vector2 direction = new Vector2(6.5f,5);
        _rb.AddForce(direction,ForceMode2D.Impulse);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rb.velocity = _rb.velocity * 1.5f;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Respawn")
        {
            SceneManager.LoadScene(0);
        }
    }
}

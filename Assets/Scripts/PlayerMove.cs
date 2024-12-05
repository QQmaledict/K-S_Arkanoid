using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour
{
    [SerializeField]private Rigidbody2D _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        Vector2 direction = new Vector2(4f,4f);
        _rb.AddForce(direction,ForceMode2D.Impulse);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Respawn")
        {
            TestBalls.ballsCount -= 1;
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            if (_rb.velocity.y <0.5f && _rb.velocity.y > -0.5f)
            {
                int i = Random.Range(0,2);
                i = i == 0 ? -3 : 3;
                Vector2 direction = new Vector2(0, i*0.3f);
                _rb.AddForce(direction, ForceMode2D.Impulse);
            }
        }
    }
}

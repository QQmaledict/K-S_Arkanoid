using UnityEngine;

[RequireComponent(typeof(Transform))]
public class PlitaMove : MonoBehaviour
{
    private Transform _tr;

    private void Start()
    {
        Cursor.visible = false;
        _tr = GetComponent<Transform>();
    }

    void Update()
    {
        if (Time.timeScale != 0)
        {
            Vector2 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouse.y = -4;
            _tr.position = mouse;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerMove>())
        {
            Vector2 Forcedirection = transform.position - collision.gameObject.transform.position;
            Forcedirection.y = Forcedirection.y > 0? -2.5f : 2.5f;
            Forcedirection.x = Forcedirection.x > 0 ? Forcedirection.x + 1.5f : Forcedirection.x - 1.5f;
            Forcedirection.x *= -2.2f;
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = Forcedirection;
        }
    }

}

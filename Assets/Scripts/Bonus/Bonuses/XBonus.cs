using UnityEngine;

public class XBonus : BonusAbs
{
    public override void Process()
    {
        Rigidbody2D rb = Instantiate(ball,gameObject.transform.position,Quaternion.identity)
            .GetComponent<Rigidbody2D>();
        int x = Random.Range(0,2);
        x = x == 0 ? -4 : 4;
        int y = Random.Range(-1,2);
        TestBalls.ballsCount += 1;
        rb.AddForce(new Vector2(x,y * 4),ForceMode2D.Impulse);
    }

}

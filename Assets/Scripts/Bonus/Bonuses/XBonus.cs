using UnityEngine;

public class XBonus : BonusAbs
{
    public override void Process()
    {
        Rigidbody2D rb = Instantiate(ball,gameObject.transform.position,Quaternion.identity)
            .GetComponent<Rigidbody2D>();
        int x = Random.Range(0,2);
        x = x == 0 ? -3 : 3;
        int y = Random.Range(0,2);
        x = x == 0 ? -3 : 3;
        TestBalls.ballsCount += 1;
        rb.AddForce(new Vector2(x,y),ForceMode2D.Impulse);
    }

}

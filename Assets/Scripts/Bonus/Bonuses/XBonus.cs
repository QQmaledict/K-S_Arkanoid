using UnityEngine;

public class XBonus : BonusAbs
{
    public override void Process()
    {
        Rigidbody2D rb = Instantiate(ball,gameObject.transform.position,Quaternion.identity)
            .GetComponent<Rigidbody2D>();
        int x = Random.Range(-5,5);
        int y = Random.Range(-1,2);
        TestBalls.ballsCount += 1;
        rb.AddForce(new Vector2(x,y * 5),ForceMode2D.Impulse);
    }

}

using UnityEngine;

public class ButtAnim : MonoBehaviour
{
    public void CloseAnim()
    {
        Animator anim = GetComponent<Animator>();
        anim.enabled = false;
    }
}

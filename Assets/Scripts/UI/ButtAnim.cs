using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtAnim : MonoBehaviour
{
    [SerializeField] private bool _isStart;
    public void CloseAnim()
    {
        Animator anim = GetComponent<Animator>();
        anim.enabled = false;
        if (_isStart)
        {
            SceneManager.LoadScene(1);
        }
    }
}

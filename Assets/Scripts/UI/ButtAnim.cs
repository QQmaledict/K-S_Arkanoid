using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtAnim : MonoBehaviour
{
    [SerializeField] private bool _isRest;
    [SerializeField] private bool _isHome;
    [SerializeField] private bool _isNull;
    [SerializeField] private bool _isSett;
    [SerializeField] private GameObject _click;
    [SerializeField] private GameObject _settingsPanel;
    public void CloseAnim()
    {
        Animator anim = GetComponent<Animator>();
        anim.enabled = false;
        if (_isRest)
        {
            SceneManager.LoadScene(1);
        }if (_isHome)
        {
            SceneManager.LoadScene(0);
        }
        if (_isNull)
        {
            PlayerPrefs.DeleteAll();

            PlayerPrefs.SetInt("Level", 1);
            SceneManager.LoadScene(0);
        }
        if (_isSett)
        {
            bool t = _settingsPanel.activeSelf == true ? false : true;
            _settingsPanel.SetActive(t);
        }
    }

    public void SoundClick()
    {
        GameObject newSound = Instantiate(_click);
        Destroy(newSound,1f);
    }
}

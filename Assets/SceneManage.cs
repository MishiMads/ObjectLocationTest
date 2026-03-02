using NUnit.Framework;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    private static SceneManage _instance;

    void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }

        DontDestroyOnLoad(gameObject);
    }


    void OnPress1(InputValue value)
    {
        SceneManager.LoadScene(1);
    }

    void OnPress2(InputValue value)
    {
        SceneManager.LoadScene(2);
    }
    
    void OnPress3(InputValue value)
    {
        SceneManager.LoadScene(3);
    }
    
    void OnPress4(InputValue value)
    {
        SceneManager.LoadScene(4);
    }
    
    void OnPress5(InputValue value)
    {
        SceneManager.LoadScene(5);
    }
    
    void OnPress6(InputValue value)
    {
        SceneManager.LoadScene(6);
    }
    
    void OnPress0(InputValue value)
    {
        SceneManager.LoadScene(7);
    }
    
}

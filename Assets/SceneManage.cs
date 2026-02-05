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
}

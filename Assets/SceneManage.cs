using NUnit.Framework;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    private static SceneManage _instance;

    public bool itemsVisible = false;

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


    void OnPress1(InputValue value) // City - Rythmic
    {
        SceneManager.LoadScene(1);
    }

    void OnPress2(InputValue value) // City - Not Rythmic
    {
        SceneManager.LoadScene(2);
    }
    
    void OnPress3(InputValue value) // ParkArrythmic
    {
        SceneManager.LoadScene(3);
    }
    
    void OnPress4(InputValue value) // ParkRhythmic
    {
        SceneManager.LoadScene(4);
    }
    
    void OnPress0(InputValue value) // This opens BasicScene - Start scene with nothing
    {
        SceneManager.LoadScene(0);
    }

    void OnToggleItems(InputValue value) // Toggles items! :D
    {
        itemsVisible = !itemsVisible;
    }
}

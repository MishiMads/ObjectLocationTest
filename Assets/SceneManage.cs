using NUnit.Framework;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using LSL;

public class SceneManage : MonoBehaviour
{
    private static SceneManage _instance;

    public bool itemsVisible = false;

    //LSL Stream Stuff
    string StreamName = "InteractionEvent";
    string StreamType = "Markers";
    private StreamOutlet outlet;
    private string[] sample = { "" };

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

    private void Start()
    {
        var hash = new Hash128();
        hash.Append(StreamName);
        hash.Append(StreamType);
        hash.Append(gameObject.GetInstanceID());
        StreamInfo streamInfo = new StreamInfo(StreamName, StreamType, 1, LSL.LSL.IRREGULAR_RATE,
            channel_format_t.cf_string, hash.ToString());
        outlet = new StreamOutlet(streamInfo);
    }

    public void LSLSend(string itemName)
    {
        string sceneName = SceneManager.GetActiveScene().name;
        sample[0] = sceneName + ";" + itemName + ";Selected";
        Debug.Log(sample[0]);
        outlet.push_sample(sample);
    }


    void OnPress1(InputValue value) // City - Rythmic
    {
        SceneManager.LoadScene(1);
        sample[0] = "CityRhythmic";
        Debug.Log(sample[0]);
        outlet.push_sample(sample);
    }

    void OnPress2(InputValue value) // City - Not Rythmic
    {
        SceneManager.LoadScene(2);
        sample[0] = "CityArrhythmic";
        Debug.Log(sample[0]);
        outlet.push_sample(sample);
    }
    
    void OnPress3(InputValue value) // ParkRhythmic
    {
        SceneManager.LoadScene(3);
        sample[0] = "ParkRhythmic";
        Debug.Log(sample[0]);
        outlet.push_sample(sample);
    }
    
    void OnPress4(InputValue value) // ParkArrhythmic
    {
        SceneManager.LoadScene(4);
        sample[0] = "ParkArrhythmic";
        Debug.Log(sample[0]);
        outlet.push_sample(sample);
    }
    
    void OnPress0(InputValue value) // This opens BasicScene - Start scene with nothing
    {
        SceneManager.LoadScene(0);
    }

    void OnToggleItems(InputValue value) // Toggles items! :D
    {
        itemsVisible = !itemsVisible;
    }

    void OnPressF(InputValue value)
    {
        sample[0] = "Recall";
        Debug.Log(sample[0]);
        outlet.push_sample(sample);
    }
}

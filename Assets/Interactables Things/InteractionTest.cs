using UnityEditor.PackageManager.UI;
using UnityEngine;
using static UnityEditor.Rendering.CameraUI;

public class InteractionTest : MonoBehaviour
{
    public InteractablesHandler interactableHandler;
    public SceneManage sceneManage;

    public string itemName;

    private void Start()
    {
        sceneManage = GameObject.FindGameObjectWithTag("Manager").GetComponent<SceneManage>();
    }

    public void DestroySelf()
    {
        interactableHandler.foundCounter++;
        Destroy(gameObject);
    }

    //LSL Marker send function
    public void SendMarker()
    {
        sceneManage.LSLSend(itemName);
    }
}

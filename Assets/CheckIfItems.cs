using UnityEngine;

public class CheckIfItems : MonoBehaviour
{
    SceneManage sceneManage;

    public GameObject items;

    void Start()
    {
        sceneManage = GameObject.FindGameObjectWithTag("Manager").GetComponent<SceneManage>();

        if (sceneManage.itemsVisible)
        {
            items.SetActive(true);
        }
        else
        {
            items.SetActive(false);
        }
    }
}

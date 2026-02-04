using UnityEngine;

public class InteractionTest : MonoBehaviour
{
    public InteractablesHandler interactableHandler;

    public void DestroySelf()
    {
        interactableHandler.foundCounter++;
        Destroy(gameObject);
    }
}

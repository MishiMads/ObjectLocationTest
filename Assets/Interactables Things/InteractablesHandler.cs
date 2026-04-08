using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class InteractablesHandler : MonoBehaviour
{
    public int foundCounter = 0;
    public List<GameObject> interactables;

    bool objectsFound;

    void Start()
    {
        foreach (var interactable in interactables)
        {
            interactable.GetComponent<InteractionTest>().interactableHandler = this;
        }
    }

    void Update()
    {
        if(foundCounter >= interactables.Count && !objectsFound)
        {
            Debug.Log("Found all objects!");
            objectsFound = true;
        }
    }
}

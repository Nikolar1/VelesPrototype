using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public GameObject buttonToCreate;
    public void InstantiateNewObject()
    {

        Instantiate(buttonToCreate, new Vector3(-3.44f, -1f, -9.07f), Quaternion.identity);
    }
}

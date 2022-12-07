using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    void InstantiateNewObject()
    {
        GameObject cube = new GameObject("NewItem");

        Instantiate(cube, new Vector3(0f, 0f, 0f), Quaternion.identity);
    }
}

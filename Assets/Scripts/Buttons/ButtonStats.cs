using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Button", menuName = "New Button")]
public class ButtonStats : ScriptableObject
{
    public int tier;
    public ISet<Button> conneceted;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour, IButton
{
    public ButtonStats baseStats;
    public bool placed;

    public ISet<IButton> connectedButtons()
    {
        HashSet<IButton> buttons = new HashSet<IButton>();
        foreach (var b in baseStats.conneceted)
        {
            buttons.Add(b);
        }
        return buttons;
    }

    public int earnings() {
        return baseStats.tier * 2;
    }

    public void disconnect()
    {
        foreach (var b in baseStats.conneceted)
        {
            b.baseStats.conneceted.Remove(this);
        }
        baseStats.conneceted.Clear();
    }

    public bool isPlaced()
    {
        return placed;
    }

    public bool mergeable(IButton b)
    {
        if (baseStats.tier == (b.earnings() / 2))
        {
            return true;
        }
        return false;
    }
    public void move(Touch touch, Vector3 offset, float distance) {
        
        Vector3 vector = new Vector3(touch.position.x, touch.position.y, distance);
        vector = Camera.main.ScreenToWorldPoint(vector);
        
        //vector.x = transform.position.x- vector.x + transform.position.x;
        //offset.x = -offset.x;
        Vector3 temp = (vector + offset);
        //temp.x = transform.position.x-temp.x + transform.position.x;
        //temp.z = -temp.z;
        gameObject.transform.position = temp;

    }
    
}

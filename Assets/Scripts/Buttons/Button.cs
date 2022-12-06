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
        
        Vector3 vector = new Vector3(touch.position.x,distance,touch.position.y);
        vector = Camera.main.ScreenToWorldPoint(vector);
        gameObject.transform.position = vector + offset;
        

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

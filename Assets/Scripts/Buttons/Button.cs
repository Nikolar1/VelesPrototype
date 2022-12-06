using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour, IButton
{
    public ButtonStats baseStats;

    public ISet<IButton> connectedButtons()
    {
        throw new System.NotImplementedException();
    }

    public int earnings() {
        throw new System.NotImplementedException();
    }

    public void disconnect()
    {
        throw new System.NotImplementedException();
    }

    public bool isPlaced()
    {
        throw new System.NotImplementedException();
    }

    public bool mergeable(IButton b)
    {
        throw new System.NotImplementedException();
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

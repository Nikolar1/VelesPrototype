using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IButton
{
    public ISet<IButton> connectedButtons(); // Returns set of buttons connected to this one including it
    public int earnings(); // Retruns value of button press
    public void disconnect(); // Disconnects this button from the others
    public bool mergeable(IButton b); // Returns if two buttons are mergable
    public bool isPlaced(); // Is it placed on the board
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public static PlayerManager instance;
    public IButton selectedButton;

    private void Awake()
    {
        instance = this;
        selectedButton = null;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        selectedButton = InputHandler.instance.handleTouchInput(selectedButton);
        
    }
}

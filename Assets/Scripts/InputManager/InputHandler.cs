using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public static InputHandler instance;
    public Vector3 offset;
    public float distance;
    private void Awake()
    {
        instance = this;
    }


    public IButton handleTouchInput(IButton selectedButton) {

        //Check if a button is already being dragged
        if (selectedButton != null)
        {
            
            if (Input.touchCount == 1)
            {
                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Moved)
                {
                    Debug.Log("sadas");
                    selectedButton.move(touch,offset,distance);
                }

                if (touch.phase == TouchPhase.Ended)
                {
                    return null;
                }
            }
        }
        else if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            if (Physics.Raycast(ray, out hit))
            {
                Touch touch = Input.GetTouch(0);
                if (hit.transform.tag == "button")
                {
                    distance = this.transform.position.y - Camera.main.transform.position.y;
                    Vector3 vector = new Vector3(touch.position.x, distance, touch.position.y);
                    vector = Camera.main.ScreenToWorldPoint(vector);
                    offset = hit.collider.gameObject.transform.position - vector;
                    return hit.collider.GetComponent<IButton>();
                }
            }
        }
        return null;
    }

}

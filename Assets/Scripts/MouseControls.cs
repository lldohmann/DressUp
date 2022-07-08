using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControls : MonoBehaviour
{
    private GameObject selectedObject;
    private GameObject selectedScript;

    Vector3 offset;
    Vector3 mousePos;
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        OnMouseDown();
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0) && Physics2D.OverlapPoint(mousePos))
        {
            Collider2D[] results = Physics2D.OverlapPointAll(mousePos);
            Collider2D highestCollider = GetHighestObject(results);
            selectedObject = highestCollider.transform.gameObject;
            offset = selectedObject.transform.position - mousePos;

        }
        if (selectedObject && !selectedObject.CompareTag("UI"))
        {
            //Debug.Log(selectedObject.tag);
            if (selectedObject.tag == "Item")
            {
                selectedObject.transform.position = mousePos + offset;
                // TO DO LEO Grab isHeld value and adjust behavior
                DollCollisionLogic selectedScript = selectedObject.GetComponent<DollCollisionLogic>();
                selectedScript.setIsHeld(true);
                if (Input.GetMouseButtonUp(0))
                {
                    selectedScript.setIsHeld(false);
                    selectedObject = null;
                    selectedScript = null;
                }
            }
        }
    }
    Collider2D GetHighestObject(Collider2D[] results)
    {
        int highestValue = 0;
        Collider2D highestObject = results[0];
        foreach (Collider2D col in results)
        {
            Renderer ren = col.gameObject.GetComponent<Renderer>();
            if (ren && ren.sortingOrder > highestValue)
            {
                highestValue = ren.sortingOrder;
                highestObject = col;
            }
        }
        return highestObject;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollCollisionLogic : MonoBehaviour
{
    public GameObject parentObject; // a ref the dress itself
    private bool isHeld = false;
    Shader rollyShader; // A reference to the the character's shader
    Shader pattyShader;
    Renderer rend;
    BoxCollider2D collisionBox;
    // Start is called before the first frame update
    void Start()
    {
        //insert the references to shaders here
        rend = parentObject.transform.GetChild(0).GetComponent<Renderer>(); // we're grabbing the arm object here.
        collisionBox = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Rolly Doll")
        {
            //reference Rolly's shader
        }
        else if (collision.gameObject.name == "Patty Doll")
        {
            //reference Patty's shader
        }
        else if (collision.gameObject.name == "Joey Doll")
        {
            //reference Joey's shader
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Dress Scroll View" && !isHeld)
        {
            Debug.Log("It works!");
            Destroy(parentObject);
        }
    }
    public void setIsHeld(bool value)
    {
        isHeld = value;

        Debug.Log(isHeld);
    }
}

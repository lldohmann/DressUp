using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollCollisionLogic : MonoBehaviour
{
    public GameObject parentObject; // a ref the dress itself
    private bool isHeld = false;
    Shader skinShader; // A reference to the the character's shader
    Renderer rend;
    BoxCollider2D collisionBox;
    private string[] shaderAttributes;
    // Start is called before the first frame update
    void Start()
    {
        //insert the references to shaders here
        //rend = parentObject.transform.GetChild(0).GetComponent<Renderer>(); // we're grabbing the arm object here. TO DO LUDVICK
        rend = GetComponent<Renderer>();
        skinShader = Shader.Find("Shader Graphs/Skin Shader Graph");
        collisionBox = GetComponent<BoxCollider2D>();
        CheckingShader(skinShader, shaderAttributes);
    }

    private void CheckingShader(Shader shader, string[] attributes)
    {
        Debug.Log("Starting CheckShader...");
        // TESTING FIGURING OUT HOW TO PRINT ALL SHADER VALUES
        for (int i = 0; i > skinShader.GetPropertyCount(); i++)
        {
            shaderAttributes = skinShader.GetPropertyAttributes(i);
            for (int j = 0; j > shaderAttributes.Length; j++)
            {
                Debug.Log(shaderAttributes[j].ToString());
                Debug.Log("Wow!");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Rolly Doll")
        {
            Debug.Log("Hit Rolly doll.");
            //rend.material.SetColor("Skin Shader Graph", new Color(250.0f, 201.0f, 145.0f, 1.0f));
            rend.material.SetColor("Skin_New_Color",Color.red);
        }
        else if (collision.gameObject.name == "Patty Doll")
        {
            Debug.Log("Hit Patty doll.");
            //reference Patty's shader
        }
        else if (collision.gameObject.name == "Joey Doll")
        {
            Debug.Log("Hit Joey doll.");
            //reference Joey's shader
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Dress Scroll View" && !isHeld)
        {
            Destroy(parentObject);
        }
    }
    public void setIsHeld(bool value)
    {
        isHeld = value;
    }
}

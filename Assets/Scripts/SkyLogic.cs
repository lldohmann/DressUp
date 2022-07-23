using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkyLogic : MonoBehaviour
{
    public float minPosX = 0.0f;
    public float maxPosX = 1084.0f;
    public float speed = 50.0f;
    RectTransform picture; 
    // Start is called before the first frame update
    void Start()
    {
        picture = GetComponent<RectTransform>(); // Get the component responsible for moving the image
    }

    // Update is called once per frame
    void Update()
    {
        picture.anchoredPosition = new Vector2(picture.anchoredPosition.x + speed * Time.deltaTime, picture.anchoredPosition.y); // Code to actually move image around
        if (picture.anchoredPosition.x > maxPosX)
        {
            picture.anchoredPosition = new Vector2(minPosX, picture.anchoredPosition.y);
        }
    }
}

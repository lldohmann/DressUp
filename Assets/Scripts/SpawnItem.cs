using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    [SerializeField]
    public GameObject itemToSpawn;

    public void OnClick()
    {
        Instantiate(itemToSpawn);//, new Vector2(10.0f, 10.0f),(Quaternion.identity)); //new Vector2(Input.mousePosition.x, Input.mousePosition.y), Quaternion.identity);
    }
}

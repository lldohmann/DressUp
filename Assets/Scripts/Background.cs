using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Background : MonoBehaviour
{
    [SerializeField]
    List<Sprite> backgrounds = new List<Sprite>();
    Image currentBG;
    // Start is called before the first frame update
    void Start()
    {
        currentBG = gameObject.GetComponent<Image>();
    }
    public void ChangeBackground(int index)
    {
        currentBG.sprite = backgrounds[index];
    }
}

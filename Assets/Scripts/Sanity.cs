using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sanity : MonoBehaviour
{
    public float sanity = 100;
    public RectTransform sanityBar;
    public Vector2 size;
    
    void Start()
    {
        size = sanityBar.sizeDelta;
        UpdateSanity(sanity);
    }

    public void UpdateSanity(float amount)
    {
        size.y += amount;
        sanityBar.sizeDelta = size;
        print(size.y);
    }
}

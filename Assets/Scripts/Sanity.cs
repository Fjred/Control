using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sanity : MonoBehaviour
{
    public float sanity = 100;
    public RectTransform sanityBar;
    public Vector2 size;

    public GameObject fakeObject;
    bool created = false;
    
    void Start()
    {
        size = sanityBar.sizeDelta;
        UpdateSanity(0);
    }
    private void FixedUpdate()
    {
        if(sanity < 10 && created == false)
        {
            Instantiate(fakeObject);
            created = !created;  
        }
    }
    public void UpdateSanity(float amount)
    {
        if (sanity < 0)
        {
            sanity = 0;
        }
        else
        {
            sanity += amount;
            size.y = sanity;
            sanityBar.sizeDelta = size;
            print(size.y);
        }
    }
}

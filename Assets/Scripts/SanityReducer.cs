using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SanityReducer : MonoBehaviour
{
    public Sanity sanity;

    int over = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("NIGA");
        if (collision.gameObject.CompareTag("Player") && over ==0)
        {
            sanity.UpdateSanity(-10);
            
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Karakter"))
        {
            if(collision.relativeVelocity.y <= 0f)
            {
                collision.gameObject.GetComponent<player>().KarakteriZiplat();
            }
        }
    }
}

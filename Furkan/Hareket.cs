﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hareket : MonoBehaviour
{
    public float hiz = 0.35f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        

        float yatay = Input.GetAxis("Horizontal");
        float dikey =Input.GetAxis("Vertical");
        transform.position += new Vector3(yatay*hiz,0,0);
        transform.position += new Vector3(0,dikey*hiz,0);

        if(yatay > 0)
        {
            transform.localScale = new Vector3(1,1,1);
            
        } else if(yatay < 0)
        {
            transform.localScale = new Vector3(-1,1,1);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Mesale temas");
    }

    void Update()
    {
        
    }
}
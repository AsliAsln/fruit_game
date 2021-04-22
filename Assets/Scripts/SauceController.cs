﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SauceController : MonoBehaviour
{
    private ParticleSystem particle;
    public SignType signType;
    // Start is called before the first frame update
    private void Start()
    {
        particle = GetComponentInChildren<ParticleSystem>();
        particle.gameObject.SetActive(false);

    }


    // Update is called once per frame
    
    private void OnTriggerEnter(Collider other)

    {
        if (other.gameObject.tag == "player")
        {
            particle.gameObject.SetActive(true);
           


        }
        else
        {
            particle.gameObject.SetActive(false);

        }

    }



}
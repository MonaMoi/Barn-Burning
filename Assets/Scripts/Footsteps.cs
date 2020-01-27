﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Die Klasse ist dafür da, dass bei einem Klick, eine Audiodatei mit einem einzelnen Fußschritt abgespielt wird.
public class Footsteps : MonoBehaviour
{
    public AudioSource steps;

    // Bei klicken des "Fire1" Button, wird die Methode audioOn() gestartet. Bei loslassen des Buttons die Methode AudioOff().
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) { audioOn() ;}
        if (Input.GetButtonUp("Fire1")) { audioOff() ;}
    }


    // Audio wird gestartet.
    void audioOn()
    {
        steps.Play();
    }

    // Audio wird gestoppt.
    void audioOff()
    {
        steps.Stop();
    }
}

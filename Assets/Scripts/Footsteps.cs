using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public AudioSource steps;
    public bool walk;


    void Update()
    {
        if (Input.GetButtonDown("Fire1")) { audioOn(); walk = true; }
        if (Input.GetButtonUp("Fire1")) { audioOff(); walk = false; }
    }

    void audioOn()
    {
        /* steps.loop
         steps.Play();
          var loop = steps.isPlaying;
          if (loop)  {
              steps.volume = Random.Range(0.8f, 1);
              GetComponent<AudioSource>().pitch = Random.Range(0.8f, 1.1f);
              GetComponent<AudioSource>().Play();
          }*/

        /* for(var i = 0; walk == true; i++) {
               GetComponent<AudioSource>().volume = Random.Range(0.8f, 1);
               GetComponent<AudioSource>().pitch = Random.Range(0.8f, 1.1f);
               steps.Play();
               if (walk == false) return;

           }*/

        steps.Play();
        
    }

    void audioOff()
    {
        steps.Stop();
    }
}

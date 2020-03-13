using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitingScript : MonoBehaviour
{

    public AudioSource Source;
    public AudioSource Source2;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        StartCoroutine("Wait");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Wait()
    {
        Source.Play();
        yield return new WaitForSeconds(3.0f);
        Source2.Play();
    }

}


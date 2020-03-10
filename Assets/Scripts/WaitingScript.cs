using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitingScript : MonoBehaviour
{

    public AudioSource Fire;

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
        yield return new WaitForSeconds(10.0f);
        Fire.Play();
    }

}


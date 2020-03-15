using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{

    public Animator anim;

    void OnTriggerEnter(Collider other)
    {
        anim = GetComponent<Animator>();
        StartCoroutine("Wait");
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(3.0f);
        anim.Play("Verschwinden");
    }
}

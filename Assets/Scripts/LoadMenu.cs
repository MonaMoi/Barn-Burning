using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadMenu : MonoBehaviour
{
    public Animator animator;

    // Beim Betreten des Triggers startet die Coroutine.
    void Start()
    {
        StartCoroutine("LoadLevelDelay");
    }

    // 
    private IEnumerator LoadLevelDelay()
    {
        animator.SetTrigger("FadeÍn");
        yield return new WaitForSeconds(4.0f);
        animator.SetTrigger("FadeOut");
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene(2);
    }


}




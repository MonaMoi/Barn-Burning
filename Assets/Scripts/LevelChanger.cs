using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    public Animator animator;
   // private int levelToLoad;
   // public static int SceneNumber;

    void Start()
    {
      //  if (SceneNumber == 0)
      //  {
            StartCoroutine(ToSplashTwo());
      //  }
      /*  if (SceneNumber == 1)
        {
            StartCoroutine(ToMenuScene());
        }*/
    }

    // Update is called once per frame
   /* void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            FadeToLevel(1);
        }
    }


    public void FadeToLevel(int levelIndex) 
    {
        levelToLoad = levelIndex;
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete() 
    {

        SceneManager.LoadScene(levelToLoad);

    }*/

    IEnumerator ToSplashTwo()
    {
        animator.SetTrigger("FadeIn");
        
        yield return new WaitForSeconds(5);
        //SceneNumber = 1;
        animator.SetTrigger("FadeOut");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

  /*  IEnumerator ToMenuScene()
    {
        animator.SetTrigger("FadeOut");
        yield return new WaitForSeconds(5);
        SceneNumber = 2;
        SceneManager.LoadScene(2);
    }*/

}

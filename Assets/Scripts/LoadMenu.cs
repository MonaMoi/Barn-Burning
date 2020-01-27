using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadMenu : MonoBehaviour
{
    public Transform target;

    // Beim Betreten des Triggers startet die Coroutine.
    void OnTriggerEnter(Collider other)
    {
        StartCoroutine("LoadLevelDelay");
    }

    // 
    private IEnumerator LoadLevelDelay()
    {
        yield return new WaitForSeconds(5.0f);

        SceneManager.LoadScene(0);
    }


}




using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadMenu : MonoBehaviour
{
    public Transform target;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Object Entered the trigger");
        Debug.Log("Object is within trigger");

        StartCoroutine("LoadLevelDelay");

    }

    private IEnumerator LoadLevelDelay()
    {
        yield return new WaitForSeconds(5.0f);

        SceneManager.LoadScene(0);
    }


}




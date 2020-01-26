using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadDay2 : MonoBehaviour
{
    public Transform target;
 // public int index = 3;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Object Entered the trigger");
        Debug.Log("Object is within trigger");

        StartCoroutine("LoadLevelDelay");

    }

    private IEnumerator LoadLevelDelay()
    {
        yield return new WaitForSeconds(10.0f);

        SceneManager.LoadScene(3);
       // SceneManager.LoadScene(index);
        
    }

}




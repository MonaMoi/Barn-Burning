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
        StartCoroutine("LoadLevelDelay");
    }

    private IEnumerator LoadLevelDelay()
    {
        yield return new WaitForSeconds(7.0f);

        SceneManager.LoadScene(6);
        
    }

}




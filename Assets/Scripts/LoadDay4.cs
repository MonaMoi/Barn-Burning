using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadDay4 : MonoBehaviour
{
    public Transform target;

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine("LoadLevelDelay");
    }

    private IEnumerator LoadLevelDelay()
    {
        yield return new WaitForSeconds(4.0f);

        SceneManager.LoadScene(6);
    }


}


using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadDay5 : MonoBehaviour
{
    public Transform target;

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine("LoadLevelDelay");
    }

    private IEnumerator LoadLevelDelay()
    {
        yield return new WaitForSeconds(5.0f);

        SceneManager.LoadScene(6);
    }


}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadNextScene : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        StartCoroutine("NextScene");
    }

    public IEnumerator NextScene()
    {
        yield return new WaitForSeconds(6.0f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

}

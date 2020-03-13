using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadAlbtraum : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("LoadLevelDelay");
    }

    private IEnumerator LoadLevelDelay()
    {
        yield return new WaitForSeconds(148.0f);

        SceneManager.LoadScene(4);
    }
}

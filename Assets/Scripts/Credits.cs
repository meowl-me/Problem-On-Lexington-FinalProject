using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CreditsBack());
    }

    IEnumerator CreditsBack()
    {
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene (0);
    }
}

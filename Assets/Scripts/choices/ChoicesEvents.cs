using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChoicesEvents : MonoBehaviour
{

    [SerializeField] GameObject fadeOut;
    [SerializeField] AudioSource buttonClick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void LeviPlan()
    {
        buttonClick.Play();
        fadeOut.SetActive(true);
        StartCoroutine(TransferToBadEnding());
    }

    public void JackiePlan()
    {
        buttonClick.Play();
        fadeOut.SetActive(true);
        StartCoroutine(TransferToGoodEnding());
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator TransferToGoodEnding()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene (5);
    }

    IEnumerator TransferToBadEnding()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene (6);
    }
}

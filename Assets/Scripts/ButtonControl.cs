using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControl : MonoBehaviour
{
    [SerializeField] GameObject fadeOut;
    [SerializeField] AudioSource buttonClick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Credits()
    {
        buttonClick.Play();
        fadeOut.SetActive(true);
        StartCoroutine(TransferToCredits());
    }
    public void MainMenu()
    {
        buttonClick.Play();
        fadeOut.SetActive(true);
        StartCoroutine(TransferToMMenu());
    }
    IEnumerator TransferToMMenu()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene (0);
    }

    IEnumerator TransferToCredits()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene (2);
    }
}

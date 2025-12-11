using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{

    [SerializeField] GameObject fadeOut;
    [SerializeField] AudioSource buttonClick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartGame()
    {
        buttonClick.Play();
        fadeOut.SetActive(true);
        StartCoroutine(TransferToFirstScene());
    }

    public void Credits()
    {
        buttonClick.Play();
        fadeOut.SetActive(true);
        StartCoroutine(TransferToCredits());
    }

     public void Quit()
    {
        buttonClick.Play();
        fadeOut.SetActive(true);
        StartCoroutine(TransferToQuitProgram());
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator TransferToFirstScene()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene (1);
    }

     IEnumerator TransferToCredits()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene (2);
    }

     IEnumerator TransferToQuitProgram()
    {
        yield return new WaitForSeconds(3);
        Application.Quit();
    }
}

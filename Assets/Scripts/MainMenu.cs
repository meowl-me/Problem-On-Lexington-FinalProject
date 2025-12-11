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
        fadeOut.SetActive(true);
        StartCoroutine(TransferToFirstScene());
        
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
}

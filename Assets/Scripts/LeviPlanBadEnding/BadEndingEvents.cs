using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BadEndingEvents : MonoBehaviour
{
    public GameObject fadeScreenIn;
    // Text Variables
    public GameObject textBox;
    [SerializeField] string textToSpeak;
    [SerializeField] int currentTextLength;
    [SerializeField] int textLength;
    [SerializeField] GameObject mainTextObject;
    // Other Variables
    [SerializeField] GameObject nextButton;
    [SerializeField] int eventPos = 0;
    [SerializeField] GameObject charName;
    [SerializeField] GameObject fadeOut;

 // Update is called once per frame
    void Update()
    {
        textLength = TextCreator.charCount;
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EventStarter());
    }


    IEnumerator EventStarter()
    {
        // event 0 
        yield return new WaitForSeconds(2);
        fadeScreenIn.SetActive(true);
        // Where text function will go
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textToSpeak = "Levi traces the IP address of the conductor. The conductor was taken into custody for interrogation. In the end, the conductor was innocent. He is now suing for pain and suffering. Both Jackie and Levi are fired for wasting time and money.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(()=> textLength == currentTextLength);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
        eventPos = 1;
    }

    IEnumerator EventOne()
    {
        // event 1
        nextButton.SetActive(false);
        textBox.SetActive(true);
        // Text 
        charName.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textToSpeak = "Fired Ending. You lost.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(()=> textLength == currentTextLength);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
        eventPos = 2;
    }
    IEnumerator EventTwo()
    {
        // event 2
        nextButton.SetActive(false);
        textBox.SetActive(true);
        // Text 
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        eventPos = 3;
        SceneManager.LoadScene(0);
    }

    public void NextButton()
    {
        if (eventPos == 1)
        {
            StartCoroutine(EventOne());
        }
        if (eventPos == 2)
        {
            StartCoroutine(EventTwo());
        }
       
    }
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene01Events : MonoBehaviour
{

    // Variables
    public GameObject fadeScreenIn;
    public GameObject charUnknown;
    public GameObject charDcarmine;
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
        fadeScreenIn.SetActive(false);
        charUnknown.SetActive(true);
        yield return new WaitForSeconds(2);
        // Where text function will go
        mainTextObject.SetActive(true);
        textToSpeak = "In October of 202X, The MTA’s intercoms were compromised, leading to an accident and delays on the Lexington Avenue line.";
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
        charUnknown.SetActive(true);
        textBox.SetActive(true);
        // Text 
        charName.GetComponent<TMPro.TMP_Text>().text = "???";
        textToSpeak = "This is very bad. NYC runs on trains.";
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

    public void NextButton()
    {
        if (eventPos == 1)
        {
            StartCoroutine(EventOne());
        }

    }
}

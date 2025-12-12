using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene02Events : MonoBehaviour
{

    // Variables
    public GameObject fadeScreenIn;
    public GameObject charDcarmineFade;
    public GameObject charDcarmine;
    public GameObject charJackieFade;
    public GameObject charJackie;
    public GameObject charLeviFade;
    public GameObject charLevi;
    public GameObject charDossier;
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
        charDcarmineFade.SetActive(true);
        yield return new WaitForSeconds(2);
        charDcarmine.SetActive(true);
        // Where text function will go
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Detective Carmine";
        textToSpeak = "This dossier contains the testimony give by Gary Mitchel. He is a 6 train conductor.";
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
        charDcarmineFade.SetActive(false);
        charDcarmine.SetActive(false);
        charDossier.SetActive(true);
        // Text 
        charName.GetComponent<TMPro.TMP_Text>().text = "Detective Carmine";
        textToSpeak = "As you may know, the 6 train is one of the most used lines in the city.";
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

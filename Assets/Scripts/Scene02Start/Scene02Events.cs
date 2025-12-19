using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene02Events : MonoBehaviour
{

    // Variables
    public GameObject fadeScreenIn;
    public GameObject charDcarmineFade;
    public GameObject charDcarmine;
    public GameObject charDcarmineMC;
    public GameObject charDcarmineAngry;
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
        textToSpeak = "This dossier contains the testimony given by Gary Mitchel. He's a 6 train conductor.";
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
    IEnumerator EventTwo()
    {
        // event 2
        nextButton.SetActive(false);
        charDossier.SetActive(true);
        // Text 
        charName.GetComponent<TMPro.TMP_Text>().text = "Detective Carmine";
        textToSpeak = "It’s no doubt that he was one of the many train personnel who were affected during the intercom attack in October.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(()=> textLength == currentTextLength);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
        eventPos = 3;
    }
    IEnumerator EventThree()
    {
        // event 3
        nextButton.SetActive(false);
        charDossier.SetActive(true);
        // Text 
        charName.GetComponent<TMPro.TMP_Text>().text = "Detective Carmine";
        textToSpeak = "This is why we need to catch these criminals quickly before they harm another train line.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(()=> textLength == currentTextLength);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
        eventPos = 4;
    }
    IEnumerator EventFour()
    {
        // event 4
        nextButton.SetActive(false);
        charDossier.SetActive(true);
        // Text 
        charName.GetComponent<TMPro.TMP_Text>().text = "Detective Carmine";
        textToSpeak = "We don’t want another 'Taking of Pelham 123.'";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(()=> textLength == currentTextLength);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
        eventPos = 5;
    }
    IEnumerator EventFive()
    {
        // event 5
        nextButton.SetActive(false);
        charDossier.SetActive(false);
        charJackie.SetActive(true);
        charLevi.SetActive(true);
        // Text 
        charName.GetComponent<TMPro.TMP_Text>().text = "Levi";
        textToSpeak = "This is... a lot. ";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(()=> textLength == currentTextLength);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
        eventPos = 6;
    }
    IEnumerator EventSix()
    {
        // event 6
        nextButton.SetActive(false);
        charJackie.SetActive(false);
        charLevi.SetActive(false);
        charJackieFade.SetActive(true);
        charLeviFade.SetActive(true);
        // Text 
        charName.GetComponent<TMPro.TMP_Text>().text = "Jackie";
        textToSpeak = "Honestly, I’m not sure where to start";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(()=> textLength == currentTextLength);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
        eventPos = 7;
    }
    IEnumerator EventSeven()
    {
        // event 7
        nextButton.SetActive(false);
        charLevi.SetActive(false);
        charJackieFade.SetActive(false);
        charLeviFade.SetActive(false);
        charDcarmineMC.SetActive(true);
        // Text 
        charName.GetComponent<TMPro.TMP_Text>().text = "Detective Carmine";
        textToSpeak = "...";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(()=> textLength == currentTextLength);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
        eventPos = 8;
    }

    IEnumerator EventEight()
    {
        // event 8
        nextButton.SetActive(false);
        charDcarmineMC.SetActive(false);
        charDcarmineAngry.SetActive(true);
        // Text 
        charName.GetComponent<TMPro.TMP_Text>().text = "Detective Carmine";
        textToSpeak = "Well, I would like more intel on criminals by the end of your shifts. Time is not on our side. I’ll leave you two to it. Don’t disappoint me.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(()=> textLength == currentTextLength);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
        eventPos = 9;
    }

    IEnumerator EventNine()
    {
        // event 9
        nextButton.SetActive(false);
        charDcarmineAngry.SetActive(false);
        charJackieFade.SetActive(true);
        charLevi.SetActive(true);
        // Text 
        charName.GetComponent<TMPro.TMP_Text>().text = "Levi & Jackie";
        textToSpeak = "Yes Ma'am!";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(()=> textLength == currentTextLength);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
        eventPos = 10;
    }

    IEnumerator EventTen()
    {
        // event 10
        nextButton.SetActive(false);
        textBox.SetActive(true);
        // Text 
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        eventPos = 11;
        SceneManager.LoadScene(4);
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
        if (eventPos == 3)
        {
            StartCoroutine(EventThree());
        }
        if (eventPos == 4)
        {
            StartCoroutine(EventFour());
        }
        if (eventPos == 5)
        {
            StartCoroutine(EventFive());
        }
        if (eventPos == 6)
        {
            StartCoroutine(EventSix());
        }
        if (eventPos == 7)
        {
            StartCoroutine(EventSeven());
        }
        if (eventPos == 8)
        {
            StartCoroutine(EventEight());
        }
        if (eventPos == 9)
        {
            StartCoroutine(EventNine());
        }
        if (eventPos == 10)
        {
            StartCoroutine(EventTen());
        }
    }
    
}

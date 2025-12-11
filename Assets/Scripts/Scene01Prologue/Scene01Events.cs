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
    IEnumerator EventTwo()
    {
        // event 2
        nextButton.SetActive(false);
        charUnknown.SetActive(true);
        textBox.SetActive(true);
        // Text 
        charName.GetComponent<TMPro.TMP_Text>().text = "???";
        textToSpeak = "Thousands of people take the Lexington line to get to their destinations.";
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
        charUnknown.SetActive(true);
        textBox.SetActive(true);
        // Text 
        charName.GetComponent<TMPro.TMP_Text>().text = "???";
        textToSpeak = "We do suspect that the attack on the intercoms was a one person ordeal.";
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
        charUnknown.SetActive(true);
        textBox.SetActive(true);
        // Text 
        charName.GetComponent<TMPro.TMP_Text>().text = "???";
        textToSpeak = "However, we haven’t gathered enough evidence to prove that yet.";
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
        charUnknown.SetActive(true);
        textBox.SetActive(true);
        // Text 
        charName.GetComponent<TMPro.TMP_Text>().text = "???";
        textToSpeak = "It is rare that a small firm like us would take on a case like this.";
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
        charUnknown.SetActive(true);
        textBox.SetActive(true);
        // Text 
        charName.GetComponent<TMPro.TMP_Text>().text = "???";
        textToSpeak = "Usually the NYPD, or even the FBI would be involved in these matters.";
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
        charUnknown.SetActive(true);
        textBox.SetActive(true);
        // Text 
        charName.GetComponent<TMPro.TMP_Text>().text = "???";
        textToSpeak = "I guess the MTA wants to keep this investigation low profile.";
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
        charUnknown.SetActive(true);
        textBox.SetActive(true);
        // Text 
        charName.GetComponent<TMPro.TMP_Text>().text = "???";
        textToSpeak = "We cannot have another incident like this again.";
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
        charUnknown.SetActive(true);
        textBox.SetActive(true);
        // Text 
        charName.GetComponent<TMPro.TMP_Text>().text = "???";
        textToSpeak = "That is why it is crucial we find the perpetrator as soon as possible.";
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
        charUnknown.SetActive(true);
        textBox.SetActive(true);
        // Text 
        charName.GetComponent<TMPro.TMP_Text>().text = "???";
        textToSpeak = "Our only problem is… We don’t have a tech department anymore.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(()=> textLength == currentTextLength);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
        eventPos = 11;
    }
IEnumerator EventEleven()
    {
        // event 11
        nextButton.SetActive(false);
        charUnknown.SetActive(true);
        textBox.SetActive(true);
        // Text 
        charName.GetComponent<TMPro.TMP_Text>().text = "???";
        textToSpeak = "Our detective firm was defunded recently so, we had to do something we’ve never done before.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(()=> textLength == currentTextLength);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
        eventPos = 12;
    }
    IEnumerator EventTweleve()
    {
        // event 12
        nextButton.SetActive(false);
        charUnknown.SetActive(true);
        textBox.SetActive(true);
        // Text 
        charName.GetComponent<TMPro.TMP_Text>().text = "???";
        textToSpeak = "Hire freelance “White Hat Hackers” to help us with this case. These freelancers have impressive resumes, but they don't have the experience with this line of work.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(()=> textLength == currentTextLength);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
        eventPos = 13;
    }

    // THIS IS WHEN DETCTIVE CARMINE IS REVEALED
    IEnumerator EventThirteen()
    {
        // event 13
        nextButton.SetActive(false);
        charUnknown.SetActive(false);
        charDcarmine.SetActive(true);
        textBox.SetActive(true);
        // Text 
        charName.GetComponent<TMPro.TMP_Text>().text = "Detective Carmine";
        textToSpeak = "We need to find out who was behind the intercom attack.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(()=> textLength == currentTextLength);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
        eventPos = 14;
    }
    IEnumerator EventFourteen()
    {
        // event 14
        nextButton.SetActive(false);
        charUnknown.SetActive(false);
        charDcarmine.SetActive(true);
        textBox.SetActive(true);
        // Text 
        charName.GetComponent<TMPro.TMP_Text>().text = "Detective Carmine";
        textToSpeak = "Once we get the intel, we will tip the NYPD so they can make the proper arrests.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(()=> textLength == currentTextLength);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
        eventPos = 15;
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
        if (eventPos == 5)
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
        if (eventPos == 11)
        {
            StartCoroutine(EventEleven());
        }
        if (eventPos == 12)
        {
            StartCoroutine(EventTweleve());
        }
        if (eventPos == 13)
        {
            StartCoroutine(EventThirteen());
        }
        if (eventPos == 14)
        {
            StartCoroutine(EventFourteen());
        }

    }
}

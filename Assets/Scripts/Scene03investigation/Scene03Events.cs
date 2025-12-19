using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene03Events : MonoBehaviour
{

    // Variables
    public GameObject fadeScreenIn;
    public GameObject charJackieFade;
    public GameObject charJackieNeuOM;
    public GameObject charJackieNeu;
    public GameObject charJackieQuesOM;
    public GameObject charJackieQues;
    public GameObject charJackieAngryOM;
    public GameObject charJackieAngryCM;
    public GameObject charJackieShockedCM;
    public GameObject charJackieShockedOM;
    public GameObject charLeviFade;
    public GameObject charLeviNeuOM;
    public GameObject charLeviNeu;
    public GameObject charLeviAngryOM;
    public GameObject charLeviAngryCM;
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
        charJackieFade.SetActive(true);
        charLeviFade.SetActive(true);
        yield return new WaitForSeconds(2);
        charJackieNeuOM.SetActive(true);
        // Where text function will go
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Jackie";
        textToSpeak = "“New York, End”? What kind of weird code-word is this?";
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
        charJackieFade.SetActive(false);
        charJackieNeuOM.SetActive(false);
        charLeviFade.SetActive(false);
        charLeviNeuOM.SetActive(true);
        charJackieQues.SetActive(true);
        // Where text function will go
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Levi";
        textToSpeak = "I dunno.";
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
        charLeviNeuOM.SetActive(false);
        charJackieQues.SetActive(false);
        charJackieQuesOM.SetActive(true);
        charLeviNeu.SetActive(true);
        // Where text function will go
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Jackie";
        textToSpeak = "I’m drawing blanks. I don’t know what to do.";
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
        charLeviNeuOM.SetActive(true);
        charJackieQues.SetActive(true);
        charJackieQuesOM.SetActive(false);
        charLeviNeu.SetActive(false);
        // Where text function will go
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Levi";
        textToSpeak = "That’s ‘cus you’re lookin’ for the wrong thing, Jack.";
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
        charLeviNeuOM.SetActive(false);
        charJackieQues.SetActive(false);
        charJackieQuesOM.SetActive(true);
        charLeviNeu.SetActive(true);
        // Where text function will go
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Jackie";
        textToSpeak = "So what do you say we should do?";
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
        // event 3 
        nextButton.SetActive(false);
        charLeviNeuOM.SetActive(true);
        charJackieQues.SetActive(true);
        charJackieQuesOM.SetActive(false);
        charLeviNeu.SetActive(false);
        // Where text function will go
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Levi";
        textToSpeak = "Trace down that conductor, that’s what.";
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
        // event 4
        nextButton.SetActive(false);
        charLeviNeuOM.SetActive(false);
        charJackieQues.SetActive(false);
        charJackieQuesOM.SetActive(false);
        charJackieAngryOM.SetActive(true);
        charLeviNeu.SetActive(true);
        // Where text function will go
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Jackie";
        textToSpeak = "Are you crazy!? No! That guy was a victim!";
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
        // event 6 
        nextButton.SetActive(false);
        charLeviNeuOM.SetActive(true);
        charJackieAngryCM.SetActive(true);
        charJackieAngryOM.SetActive(false);
        charLeviNeu.SetActive(false);
        // Where text function will go
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Levi";
        textToSpeak = "That’s what he wants you to believe. I believe the innocent are always guilty. Look how pitiful he makes himself sound in the dossier. It’s like he knows something we don’t.";
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
        // event 4
        nextButton.SetActive(false);
        charLeviNeuOM.SetActive(false);
        charJackieAngryCM.SetActive(false);
        charJackieAngryOM.SetActive(true);
        charLeviNeu.SetActive(true);
        // Where text function will go
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Jackie";
        textToSpeak = "No Levi, we are not tracing down that poor conductor. It would be a massive waste of time.";
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
        // event 6 
        nextButton.SetActive(false);
        charLeviNeuOM.SetActive(true);
        charJackieAngryCM.SetActive(true);
        charJackieAngryOM.SetActive(false);
        charLeviNeu.SetActive(false);
        // Where text function will go
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Levi";
        textToSpeak = "I bet you would eat those words if you knew that the conductor posted about hating his job back in 2023 on his Twitter account.";
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
        // event 4
        nextButton.SetActive(false);
        charLeviNeuOM.SetActive(false);
        charJackieAngryCM.SetActive(false);
        charJackieAngryOM.SetActive(false);
        charJackieShockedOM.SetActive(true);
        charLeviNeu.SetActive(true);
        // Where text function will go
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Jackie";
        textToSpeak = "What...?";
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
        // event 6 
        nextButton.SetActive(false);
        charLeviNeuOM.SetActive(true);
        charJackieShockedOM.SetActive(false);
        charJackieShockedCM.SetActive(true);
        charLeviNeu.SetActive(false);
        // Where text function will go
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Levi";
        textToSpeak = "I looked at his LinkedIn, too. He has a degree in Software Engineering. He could be our criminal.";
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
        // event 4
        nextButton.SetActive(false);
        charLeviNeuOM.SetActive(false);
        charJackieShockedOM.SetActive(false);
        charJackieShockedCM.SetActive(false);
        charJackieAngryOM.SetActive(true);
        charLeviNeu.SetActive(true);
        // Where text function will go
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Jackie";
        textToSpeak = "No, we're gonna waste so much time doing that. Let's just use what we were given.";
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
    IEnumerator EventThirteen()
    {
        // event 6 
        nextButton.SetActive(false);
        charLeviNeuOM.SetActive(false);
        charJackieAngryCM.SetActive(true);
        charJackieAngryOM.SetActive(false);
        charLeviNeu.SetActive(false);
        charLeviAngryOM.SetActive(true);
        // Where text function will go
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Levi";
        textToSpeak = "You know what, we're tracing the train conductor. He has the skills, the motive, everything.";
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
        // event 6 
        nextButton.SetActive(false);
        charLeviNeuOM.SetActive(false);
        charJackieAngryCM.SetActive(false);
        charJackieAngryOM.SetActive(true);
        charLeviAngryOM.SetActive(false);
        charLeviAngryCM.SetActive(true);
        // Where text function will go
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Jackie";
        textToSpeak = "No. Horrible idea.";
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
    IEnumerator EventFifteen()
    {
        // event 6 
        nextButton.SetActive(false);
        charLeviNeuOM.SetActive(false);
        charJackieAngryCM.SetActive(true);
        charJackieAngryOM.SetActive(false);
        charLeviAngryOM.SetActive(true);
        charLeviAngryCM.SetActive(false);
        // Where text function will go
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Levi";
        textToSpeak = "We're tracing the IP of that conductor. ";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(()=> textLength == currentTextLength);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
        eventPos = 16;
    }
    IEnumerator EventSixteen()
    {
        // event 6 
        nextButton.SetActive(false);
        charLeviNeuOM.SetActive(false);
        charJackieAngryCM.SetActive(false);
        charJackieAngryOM.SetActive(true);
        charLeviAngryOM.SetActive(false);
        charLeviAngryCM.SetActive(true);
        // Where text function will go
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Jackie";
        textToSpeak = "Levi… We should just stick to the plan.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(()=> textLength == currentTextLength);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
        eventPos = 17;
    }
    IEnumerator EventSeventeen()
    {
        // event 6 
        nextButton.SetActive(false);
        charLeviNeuOM.SetActive(false);
        charJackieAngryCM.SetActive(true);
        charJackieAngryOM.SetActive(false);
        charLeviAngryOM.SetActive(false);
        charLeviAngryCM.SetActive(true);
        // Where text function will go
        mainTextObject.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "???";
        textToSpeak = "Choices";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(()=> textLength == currentTextLength);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
        eventPos = 18;
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
        if (eventPos == 15)
        {
            StartCoroutine(EventFifteen());
        }
        if (eventPos == 16)
        {
            StartCoroutine(EventSixteen());
        }
        if (eventPos == 17)
        {
            StartCoroutine(EventSeventeen());
        }

        
    }

  
}

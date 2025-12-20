using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoodEndingEvents : MonoBehaviour
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
        textToSpeak = "The code word “New York, End” that the criminal used during the intercom attack turned out to be a clue.";
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
        textToSpeak = "When the letters were unscrambled, the name, “Kenny Ordew” was in the mix.";
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
        // event 1
        nextButton.SetActive(false);
        textBox.SetActive(true);
        // Text 
        charName.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textToSpeak = "Kenny Ordew, a MTA board member, was taken in for questioning. Further research shows that Ordew was the knowledge capable of a cyber attack of this scale.";
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
        // event 1
        nextButton.SetActive(false);
        textBox.SetActive(true);
        // Text 
        charName.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textToSpeak = "He pleaded guilty and his motives are still unknown.";
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
        // event 1
        nextButton.SetActive(false);
        textBox.SetActive(true);
        // Text 
        charName.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textToSpeak = "Detective Carmine was pleased with Jackie and Levi’s work.";
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
        // event 1
        nextButton.SetActive(false);
        textBox.SetActive(true);
        // Text 
        charName.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textToSpeak = "They were given permanent positions at the detective firm. They are now earning a stable income.";
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
        // event 1
        nextButton.SetActive(false);
        textBox.SetActive(true);
        // Text 
        charName.GetComponent<TMPro.TMP_Text>().text = "Narrator";
        textToSpeak = "Hired Ending. You Won!";
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
        // event 2
        nextButton.SetActive(false);
        textBox.SetActive(true);
        // Text 
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        eventPos = 8;
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
    }
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Traductions : MonoBehaviour
{
    [Header("SCRIPTABLE OBJECTS")]
    public Texts language1;
    public Texts language2;
    public Texts language3;

    [Header("TRADUCTIONS")]
    public Text traductionLanguage;
    public Text traductionText;

    [Header("BUTTONS TEXTS")]
    public Text buttonText1;
    public Text buttonText2;
    public Text buttonText3;

    public void FirstTraduction()
    {
        traductionLanguage.text = language1.traductionLanguage;
        traductionText.text = language1.traductionText;
        buttonText1.text = language1.buttonText1;
        buttonText2.text = language1.buttonText2;
        buttonText3.text = language1.buttonText3;
    }

    public void SecondTraduction()
    {
        traductionLanguage.text = language2.traductionLanguage;
        traductionText.text = language2.traductionText;
        buttonText1.text = language2.buttonText1;
        buttonText2.text = language2.buttonText2;
        buttonText3.text = language2.buttonText3;
    }

    public void ThirdTraduction()
    {
        traductionLanguage.text = language3.traductionLanguage;
        traductionText.text = language3.traductionText;
        buttonText1.text = language3.buttonText1;
        buttonText2.text = language3.buttonText2;
        buttonText3.text = language3.buttonText3;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class translator : MonoBehaviour
{
    public GameObject OutputField;
    
    // Key Word Files
    public TextAsset keyWordsForAndText;
    public TextAsset keyWordsForCreateText;
    public TextAsset keyWordsForDemandText;
    public TextAsset keyWordsForWithText;

    public TextAsset keyWordsDemandForScriptText;
    public TextAsset keyWordsDemandForWebsiteText;
   
    public TextAsset keyWordsHtmlCssForCssText;
    public TextAsset keyWordsHtmlCssForHtmlText;
    public TextAsset keyWordsHtmlCssForCssDescriptivesText;
    public TextAsset keyWordsHtmlCssForHtmlDescriptivesText;
    // Key Word Files 
    // Key Word Strings
    private string andText;
    private string createText;
    private string demandText;
    private string withText;
    
    private string scriptText;
    private string websiteText;

    private string cssActionsText;
    private string htmlActionsText;
    private string cssDescriptivesText;
    private string htmlDescriptivesText;
    // Key Word Strings

    private string input;


    void Start()
    {
        andText = keyWordsForAndText.text.ToString();
        createText = keyWordsForAndText.text.ToString();
        demandText = keyWordsForAndText.text.ToString();
        withText = keyWordsForAndText.text.ToString();

        scriptText = keyWordsForAndText.text.ToString();
        websiteText = keyWordsForAndText.text.ToString();

        cssActionsText = keyWordsForAndText.text.ToString();
        htmlActionsText = keyWordsForAndText.text.ToString();
        cssDescriptivesText = keyWordsForAndText.text.ToString();
        htmlDescriptivesText = keyWordsForAndText.text.ToString();
    }

    public void ReadStringInput(string s){
        input = s;
    }

    public void CheckStringInput(){
        
    }
}
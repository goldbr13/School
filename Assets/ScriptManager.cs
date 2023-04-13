using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms.Impl;

public class ScriptManager : MonoBehaviour
{
    private string[] script = new string[] { "Teacher: Hello students today we will present your speeches on civilizations. Ok lets have our presenter discussing egypt civilization come up first!",
        "Student [inner thoughts]: Oh my gosh that’s me! I’m first?! But what if I’m not ready?!",
        "Student: My presentation is on the factors that make egypt is a civilization. One factor is record keeping. The Egyptians created a system of hiero hei herio...",
        "Student: Another factor is they would use pictures to represent ideas or whole words. They also had new tools and techniques that were made to solve problems. Some examples of advanced technologies were uh umm uh...",
        "Student: Additionally, they also has complex institutions which are long-lasting pattern of organization in a community.",
        "Teacher: Could please speak up we can’t hear you in the back!",
        "The last factor is they had advanced cities such as Memphis and Thebes."};
    private string[] prompts = new string[] {"You're up first! What will you do?", "You just stuttered! What do you do next?", "You lost your train of thought! What do you do next?", "You've been told to speak up! What do you do next?",
        "You've completed your speech! What do you do?"};
    private string[] choices = new string[] { "Envision success", "Let thoughts overwhelm you", "Think negative thoughts", "Take a deep breath and recollect", "Discourage yourself", "Get upset",
    "Review notecards", "BS", "Discourage yourself", "Take a deep breath, articulate and project", "Feel intimidated and speak softer", "Feel humiliated", "Criticize yourself on your performanc",
    "Mentally applaud yourself for facing your fears", "Question your performance"};

    private int pos = 0;
    private int score = 0;

    public TMP_Text dialogue;// make this private and get through game component!!
    public TMP_Text prompt;// make this private and get through game component!!
    public Text choice1;// make this private and get through game component!!
    public Text choice2;// make this private and get through game component!!
    public Text choice3;// make this private and get through game component!!
    public TMP_Text scoreText;// make this private and get through game component!!

    private GameObject dialogueBox;
    private GameObject promptBox;

    public movement movementScript;
    private Camera presentation;
    private Camera seated;
    private int enabler = 0;
    private int index = 0;

    public GameObject nextButton;

    void Start()
    {
        dialogueBox = GameObject.Find("TextBox");
        promptBox = GameObject.Find("Choices");
        nextButton = GameObject.Find("NextButton");
        scoreText.text = "Score: 0";
        
        promptBox.SetActive(false);
        dialogue.text = script[pos];

        GameObject cameraObject1 = GameObject.Find("PresentCamera");
        GameObject cameraObject2 = GameObject.Find("SittingCamera");
        presentation = cameraObject1.GetComponent<Camera>();
        seated = cameraObject2.GetComponent<Camera>();
        presentation.enabled = false;
        seated.enabled = true;


    }

    // Update is called once per frame
    void Update()
    {
        /*if(pos == 2 && enabler == 0){
            nextButton.SetActive(false);
            enabler++;
        }*/
        SwitchCameras();
        if (pos == 2 && enabler == 0)
        {
            nextButton.SetActive(true);

            // Hide dialogue box
            dialogueBox.SetActive(false);
            // Display option box
            promptBox.SetActive(true);
            prompt.text = prompts[index];
            // Choices
            choice1.text = choices[0];
            choice2.text = choices[1];
            choice3.text = choices[2]; 
            // added this maybe remove
            nextButton.SetActive(false);
            enabler++;
            index++;
        }
        else if (pos == 3 && enabler == 1)
        {
            //nextButton.SetActive(true);

            // Hide dialogue box
            dialogueBox.SetActive(false);
            // Display option box
            promptBox.SetActive(true);
            prompt.text = prompts[index];
            // Choices
            choice1.text = choices[3];
            choice2.text = choices[4];
            choice3.text = choices[5];
            enabler++;
            index++;
        }
        else if (pos == 4 && enabler == 2)
        {
            // Hide dialogue box
            dialogueBox.SetActive(false);
            // Display option box
            promptBox.SetActive(true);
            prompt.text = prompts[index];
            // Choices
            choice1.text = choices[6];
            choice2.text = choices[7];
            choice3.text = choices[8];
            enabler++;
            index++;
        }
        else if (pos == 7 && enabler == 3)
        {
            // Hide dialogue box
            dialogueBox.SetActive(false);
            // Display option box
            promptBox.SetActive(true);
            prompt.text = prompts[index];
            // Choices
            choice1.text = choices[9];
            choice2.text = choices[10];
            choice3.text = choices[11];
            enabler++;
            index++;
        }
        else if (pos == 8 && enabler == 4)
        {
            // Hide dialogue box
            dialogueBox.SetActive(false);
            // Display option box
            promptBox.SetActive(true);
            prompt.text = prompts[index];
            // Choices
            choice1.text = choices[12];
            choice2.text = choices[13];
            choice3.text = choices[14];
            enabler++;
            index++;
        }
        
        //Display dialogue if arrow is clicked increment pos and display again
    }

    void SwitchCameras() {
         
        if (movementScript.isAnimationFinished) {
            presentation.enabled = true;
            seated.enabled = false;
            nextButton.SetActive(true);
        }
    }

    public void OnNext()
    {
        if (pos + 1 > script.Length)
        {
            nextButton.SetActive(false);
        }
        else
        {
            pos++;
            dialogue.text = script[pos];
        }
    }

    public void OnRight()
    {
        score++;
        scoreText.text = "Score: " + score;
        promptBox.SetActive(false);
        dialogueBox.SetActive(true);
    }

    public void OnWrong()
    {
        promptBox.SetActive(false);
        dialogueBox.SetActive(true);
    }
}

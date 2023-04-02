using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms.Impl;

public class ScriptManager : MonoBehaviour
{
    private string[] script = new string[] { "Teacher: Hello students today we will present your speaches on civilizations. Ok lets have our presenter discussing egypt civilization come up first!",
        "Student [inner thoughts]: Oh my gosh that’s me! I’m first?! But what if I’m not ready?!",
        "Student: My presentation is on the factors that make egypt is a civilization. One factor is record keeping. The Egyptians created a system of hiero hei herio...",
        "Student: Another factor is they would use pictures to represent ideas or whole words. They also had new tools and techniques that were made to solve problems. Some examples of advanced technologies were uh umm uh...",
        "Student: Additionally, they also has complex institutions which are long-lasting pattern of organization in a community.",
        "Teacher: Could please speak up we can’t hear you in the back!",
        "The last factor is they had advanced cities such as Memphis and Thebes."};
    private string[] prompts = new string[] {"You just stuttered! What do you do next?", "You lost your train of thought! What do you do next?", "You've been told to speak up! What do you do next?",
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

    private GameObject dialogueBox;
    private GameObject promptBox;

    

    void Start()
    {
        dialogueBox = GameObject.Find("TextBox");
        promptBox = GameObject.Find("Choices");
        promptBox.SetActive(false);
        dialogue.text = script[pos];
    }

    // Update is called once per frame
    void Update()
    {
        if (pos == 3)
        {
            // Hide dialogue box
            dialogueBox.SetActive(false);
            // Display option box
            promptBox.SetActive(true);
            prompt.text = prompts[0];
            // Choices
            choice1.text = choices[0];
            choice2.text = choices[1];
            choice3.text = choices[2];
        }
        else if (pos == 4)
        {
            // Hide dialogue box
            dialogueBox.SetActive(false);
            // Display option box
            promptBox.SetActive(true);
            prompt.text = prompts[1];
            // Choices
            choice1.text = choices[3];
            choice2.text = choices[4];
            choice3.text = choices[5];
        }
        else if (pos == 6)
        {
            // Hide dialogue box
            dialogueBox.SetActive(false);
            // Display option box
            promptBox.SetActive(true);
            prompt.text = prompts[2];
            // Choices
            choice1.text = choices[6];
            choice2.text = choices[7];
            choice3.text = choices[8];
        }
        else if (pos == 7)
        {
            // Hide dialogue box
            dialogueBox.SetActive(false);
            // Display option box
            promptBox.SetActive(true);
            prompt.text = prompts[3];
            // Choices
            choice1.text = choices[9];
            choice2.text = choices[10];
            choice3.text = choices[11];
        }

        //Display dialogue if arrow is clicked increment pos and display again
    }

    public void OnClick()
    {
        if(pos + 1 > script.Length)
        {
            //remove next button
        }
        pos++;
        dialogue.text = script[pos];
    }
}

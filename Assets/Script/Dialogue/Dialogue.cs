using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{

    public TextMeshProUGUI textComponent;
    public TextMeshProUGUI chatterName;

    // Buttons
    public UnityEngine.UI.Button button1;
    public UnityEngine.UI.Button button2;
    public UnityEngine.UI.Button button3;

    private TextMeshProUGUI b1text;
    private TextMeshProUGUI b2text;
    private TextMeshProUGUI b3text;

    // Event Button Variables
    private bool isInChoice = false;
    private int choiceValue = -1;


    private string[,] lines;
    // lines[index, 0] --> name
    // lines[index, 1] --> dialogue

    // Dialogue Images
    public Sprite alchemist;
    public Sprite carlosHealed;
    public Sprite carlos;
    public Sprite hatarim;
    public Sprite romeo;
    public GameObject pfpPanel;
    public Image pfp;

    bool isInDialogue = false;

    public float textSpeed;

    private int index;

    private DialogueMaster dialogue;

    private GameStateManager gameState = GameStateManager.gameState;

    private int dialogueID;
    /*
    0 - Intro
    1 - Marjorie1
    2 - Isa1
    3 - Romeo1
    4 - Hatarim1
    5 - Marjorie2
    6 - Isa2
    7 - FinaleGood
    8 - FinaleBad
    */

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        textComponent.text = string.Empty;
        chatterName.text = string.Empty;

        button1.gameObject.SetActive(false);
        button2.gameObject.SetActive(false);
        button3.gameObject.SetActive(false);

        gameObject.SetActive(false);

        b1text = button1.GetComponentInChildren<TextMeshProUGUI>();
        b2text = button2.GetComponentInChildren<TextMeshProUGUI>();
        b3text = button3.GetComponentInChildren<TextMeshProUGUI>();

        pfpPanel.gameObject.SetActive(false);

        // -------------------------------------
        // Temporary

        //dialogue = new Intro1_1();
            
        //lines = dialogue.dialogue;

        // -------------------------------------
        
        //startDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) {
            if (isInChoice) {
            } else if (textComponent.text == lines[index, 1]) {
                NextLine();
            } else {
                StopAllCoroutines();
                textComponent.text = lines[index, 1];

            }
        }
    }

    void startDialogue()
    {
        isInDialogue = true;
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine() {
    /*
    0 - Intro
    1 - Marjorie1
    2 - Isa1
    3 - Romeo1
    4 - Hatarim1
    5 - Marjorie2
    6 - Isa2
    7 - FinaleGood
    8 - FinaleBad
    */

        chatterName.text = lines[index, 0];
        string name = chatterName.text;

        switch(dialogueID) {
            case 0:
            case 7:
            case 8:
                if (name == "Carlos?") {
                    pfpPanel.gameObject.SetActive(true);
                    pfp.sprite = carlos;
                } else if(name == "Carlos") {
                    pfpPanel.gameObject.SetActive(true);
                    pfp.sprite = carlosHealed;
                } else {
                    pfpPanel.gameObject.SetActive(false);
                }
                break;
            case 1:
            case 5:
            case 2:
            case 6:
                if (name == "Alchemist" || name == "Marjorie" || name == "Isa") {
                    pfpPanel.gameObject.SetActive(true);
                    pfp.sprite = alchemist;
                } else {
                    pfpPanel.gameObject.SetActive(false);
                }
                break;
            case 3:
                if (name == "???" || name == "Romeo?" || name == "Romeo") {
                    pfpPanel.gameObject.SetActive(true);
                    pfp.sprite = romeo;
                } else {
                    pfpPanel.gameObject.SetActive(false);
                }
                break;
            case 4:
                if (name == "Hatarim?") {
                    pfpPanel.gameObject.SetActive(true);
                    pfp.sprite = hatarim;
                } else {
                    pfpPanel.gameObject.SetActive(false);
                }
                break;
        }
        
        foreach (char c in lines[index, 1].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine() {
        index++; 
        if (index <= lines.GetLength(0) - 1) {
            //Debug.Log(index + " " + (lines.Length/2-1));
            textComponent.text = string.Empty;
            chatterName.text = string.Empty;
            StartCoroutine(TypeLine());
        } else {
            choiceValue = dialogue.onEnd;
            dialogueSwitch();
        }
    }

    void updateLines(string[,] text) {
        lines = text;
    }


    void dialogueSwitch() {  
            switch (choiceValue) {
                case 0: // close ui (Intro1_2, Romeo1_1, Marjorie1_2, Marjorie2_1, Isa1_2, Isa2_1, Hatarim1_2)
                    textComponent.text = string.Empty;
                    chatterName.text = string.Empty;
                    gameObject.SetActive(false);
                    isInDialogue = false;
                    break;
                case 1: // end of Intro1_1
                    button1.gameObject.SetActive(true);
                    b1text.text = "I hear you... Quiet down, will you, please?";
                    isInChoice = true;
                    break;
                case 2: // Marjorie1_1
                    b1text.text = "Can you tell me more about her?";
                    b2text.text = "I'll take your word for it.";
                    button1.gameObject.SetActive(true);
                    button2.gameObject.SetActive(true);

                    isInChoice = true;
                    break;
                case 3: // Marjorie1_1_1, Marjorie1_1_2
                    dialogue = new Marjorie1_2();
                    lines = dialogue.dialogue;
                    textComponent.text = string.Empty;
                    chatterName.text = string.Empty;
                    startDialogue();
                    break;
                case 4: // Isa1_1
                    button1.gameObject.SetActive(true);
                    b1text.text = "Nothing, beside the fact that she doesn't like you very much.";
                    if (gameState.MI) {
                        button2.gameObject.SetActive(true);
                        b2text.text = "About what happened to her hand.";
                    }
                    isInChoice = true;
                    break;
                case 5: // Isa1_1_1, Isa1_1_2
                    dialogue = new Isa1_2();
                    lines = dialogue.dialogue;
                    textComponent.text = string.Empty;
                    chatterName.text = string.Empty;
                    startDialogue();
                    break;
                case 6: // Hatarim1_1
                    button1.gameObject.SetActive(true);
                    b1text.text = "What may I call you?";
                    button2.gameObject.SetActive(true);
                    b2text.text = "What else did The Root whisper to you?";
                    if (gameState.IH) {
                        b3text.text = "Do you know Isa by chance?";
                        button3.gameObject.SetActive(true);
                    }
                    isInChoice = true;
                    break;
                case 7: // Hatarim1_1_1, Hatarim1_1_2
                    dialogue = new Hatarim1_2();
                    lines = dialogue.dialogue;
                    textComponent.text = string.Empty;
                    chatterName.text = string.Empty;
                    startDialogue();
                    break;
                case 8: // Finale1_1
                    textComponent.text = string.Empty;
                    chatterName.text = string.Empty;
                    gameObject.SetActive(false);
                    SceneManager.LoadScene("GameOver");
                    break;
                case 9: // Finale2_1
                    textComponent.text = string.Empty;
                    chatterName.text = string.Empty;
                    gameObject.SetActive(false);
                    SceneManager.LoadScene("GameOver");
                    break;
                default:
                    break;

            }
    }

    public void onClickOption1() {
        button1.gameObject.SetActive(false);
        button2.gameObject.SetActive(false);
        button3.gameObject.SetActive(false);
        isInChoice = false;

        switch (choiceValue) {
            case 1:
                dialogue = new Intro1_2();
                break;
            case 2: // Marjorie1_1 choice 1
                dialogue = new Marjorie1_1_1();
                gameState.MI = true;
                break;
            case 4: // Isa1_1 choice 2
                dialogue = new Isa1_1_2();
                break;
            case 6: // Hatarim1_1 skip
                dialogue = new Hatarim1_2();
                break;
                

        }

        lines = dialogue.dialogue;
        textComponent.text = string.Empty;
        chatterName.text = string.Empty;
        startDialogue();
    }
    public void onClickOption2() {
        button1.gameObject.SetActive(false);
        button2.gameObject.SetActive(false);
        button3.gameObject.SetActive(false);
        isInChoice = false;

        switch (choiceValue) {
            case 2: // Marjorie1_1 choice 2
                dialogue = new Marjorie1_1_2();
                break;
            case 4: // Isa1_1 choice 1
                dialogue = new Isa1_1_1();
                gameState.IH = true;
                break;
            case 6: // Hatarim1_1 choice 2
                dialogue = new Hatarim1_1_2();
                break;
                
        }

        lines = dialogue.dialogue;
        textComponent.text = string.Empty;
        chatterName.text = string.Empty;
        startDialogue();
    }
    public void onClickOption3() {
        button1.gameObject.SetActive(false);
        button2.gameObject.SetActive(false);
        button3.gameObject.SetActive(false);
        isInChoice = false;

        switch (choiceValue) {
            case 6: // Hatarim1_1 Choice 1
                dialogue = new Hatarim1_1_1();
                break;
        }

        lines = dialogue.dialogue;
        textComponent.text = string.Empty;
        chatterName.text = string.Empty;
        startDialogue();
    }

    public bool isPlayerInDialogue() {
        return isInDialogue;
    }

    public void startDialogue(int ID) {
        dialogueID = ID;
        switch (ID) {
            case 0:
                dialogue = new Intro1_1();
                break;
            case 1:
                dialogue = new Marjorie1_1();
                break;
            case 2:
                dialogue = new Isa1_1();
                break;
            case 3:
                dialogue = new Romeo1_1();
                break;
            case 4:
                dialogue = new Hatarim1_1();
                break;
            case 5:
                dialogue = new Marjorie2_1();
                break;
            case 6:
                dialogue = new Isa2_1();
                break;
            case 7:
                dialogue = new Finale1_1();
                break;
            case 8:
                dialogue = new Finale2_1();
                break;
        }

        gameObject.SetActive(true);
        pfpPanel.gameObject.SetActive(false);
        lines = dialogue.dialogue;
        textComponent.text = string.Empty;
        chatterName.text = string.Empty;
        startDialogue();
    }
}

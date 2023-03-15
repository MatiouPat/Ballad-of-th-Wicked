using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueController : MonoBehaviour
{

    public static DialogueController instance;
    public Text nameText;
    public Text dialogueText;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de DialogueController dans la scène");
        }
        instance = this;
    }

    public void StartDialogue()
    {

    }

}

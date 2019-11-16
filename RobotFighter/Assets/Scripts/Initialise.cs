using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initialise : MonoBehaviour
{
    // Start is called before the first frame update
    List<string> commands;
    List<KeyCode> inputs;

    [SerializeField]
    private Button[] buttons;

    [SerializeField]
    private Prompt prompt;

    private float timer = 0;
    private float switchTime = 10;

    private void Awake()
    {
        timer = switchTime;
        commands = new List<string>() {"Exhaust heat", "Start Mecha Engine", 
                                       "Initialize Hyperbeam", "Activate Lasers", 
                                       "Enhance Vision", "Auto-lock Target", 
                                       "Defensive Missiles", "Cancel self-destruct sequence"};

        inputs = new List<KeyCode>() {KeyCode.A, KeyCode.W, KeyCode.S, KeyCode.D, KeyCode.UpArrow,
                                      KeyCode.DownArrow, KeyCode.LeftArrow, KeyCode.RightArrow};

        for (int buttonIndex = 0; buttonIndex < buttons.Length; buttonIndex++)
        {
            buttons[buttonIndex].SetValues(commands[buttonIndex], inputs[buttonIndex], prompt);
        }

        prompt.SetValues(commands);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

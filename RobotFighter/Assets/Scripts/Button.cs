using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    // Start is called before the first frame update
    private string command;
    private KeyCode key;

    private Prompt prompt;

    public void SetValues(string command, KeyCode key, Prompt prompt)
    {
        this.command = command;
        this.key = key;
        this.prompt = prompt;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            if (command == prompt.GetCommand())
            {
                Debug.Log("Did it!");
                prompt.ChangePrompt();
            }
            else
            {
                Debug.Log("That wrong");
            }
        }
    }
}

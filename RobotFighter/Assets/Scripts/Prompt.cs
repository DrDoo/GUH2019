using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Prompt : MonoBehaviour
{
    private List<string> commands;

    private float switchTime = 10;
    private float timer = 0;

    [SerializeField]
    private TextMeshProUGUI promptScreen;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0.1f;
    }

    public void SetValues(List<string> commands) { this.commands = commands; }

    public string GetCommand() { return promptScreen.text; }

    public void ChangePrompt() { timer = 0; }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer < 0)
        {
            int index = Random.Range(0, 8);
            timer = switchTime;
            promptScreen.text = commands[index];
        }
    }
}

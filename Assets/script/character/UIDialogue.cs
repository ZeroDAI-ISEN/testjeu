using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(Canvas))]
public class UIDialogue : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI contentText;
    [SerializeField] private TextMeshProUGUI titleText;

    private Canvas canvas;

    private void Awake()
    {
        canvas = GetComponent<Canvas>();
        CloseDialogue();
    }

    public void SetDialogue(string _content, string _title)
    {
        canvas.enabled = true;
        contentText.text = _content;
        titleText.text = _title;
    }
    public void CloseDialogue()
    {
        canvas.enabled = false;
    }
}

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[System.Serializable]
public struct Line
{
    public Character character;

    [TextArea(2, 5)]
    public string text;
}


[CreateAssetMenu(fileName = "New Conversation", menuName = "Conversation")]
public class Conversation : ScriptableObject
{
    public bool EndedDialogo = false;
    public Conversation FinalConversation;

    public Character speakerLeft;
    public Character speakerRight;
    public Line[] lines;

    public Question question;
    public Conversation nextConversation;
}
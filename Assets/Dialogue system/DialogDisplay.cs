using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using UnityEngine.UI;

[System.Serializable]
public class QuestionEvent: UnityEvent<Question> {}
public class DialogDisplay : MonoBehaviour
{
    public GameObject Panel;

    public Conversation conversation;
    public QuestionEvent questionEvent;

    public GameObject speakerLeft;
    public GameObject speakerRight;

    private SpeakerUI speakerUILeft;
    private SpeakerUI speakerUIRight;

    private int activeLineIndex = 1;
    private bool conversationStarted = false;

    private bool FinishedLine = false;
    public GameObject player;

    private int VecesDialogo = 0;

    void OnEnable()
    {

        speakerUILeft = speakerLeft.GetComponent<SpeakerUI>();
        speakerUIRight = speakerRight.GetComponent<SpeakerUI>();
        conversationStarted = false;
        AdvanceLine();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) && (conversationStarted == false || FinishedLine == true))
        {
            AdvanceLine();
        }
    }

    //Si aún hay líneas en la conversación la continuamos
    private void AdvanceLine()
    {
        if (conversation == null) return;
        if (!conversationStarted) Initialize();
        if (activeLineIndex < conversation.lines.Length)
        {
            DisplayLine();
        }
        else
        {
            AdvanceConversation();
        }
    }

    //Si la conversación aún no comienza la iniciamos
    private void Initialize()
    {
        conversationStarted = true;
        activeLineIndex = 0;
        speakerUILeft.Speaker = conversation.speakerLeft;
        speakerUIRight.Speaker = conversation.speakerRight;
    }

    //Esto muestra las líneas
    void DisplayLine()
    {
        FinishedLine = false;
        Line line = conversation.lines[activeLineIndex];
        Character character = line.character;

        if (speakerUILeft.SpeakerIs(character))
        {
            SetDialog(speakerUILeft, speakerUIRight, line.text);
        }
        else
        {
            SetDialog(speakerUIRight, speakerUILeft, line.text);
        }
        activeLineIndex += 1;
    }

    //Llegamos al final de las líneas de la conversación, vemos si hay pregunta u otra conv.
    private void AdvanceConversation()
    {
        if (conversation.question != null)
        {
            questionEvent.Invoke(conversation.question);
            speakerUILeft.Hide();
            speakerUIRight.Hide();
        }
        else if (conversation.nextConversation != null)
        {
            ChangeConversation(conversation.nextConversation);
        }
        else
            EndConversation();            
    }

    //cambiamos a la siguiente conversación
    public void ChangeConversation(Conversation nextConversation)
    {
        conversationStarted = false;
        conversation = nextConversation;
        AdvanceLine();
    }

    void SetDialog(
        SpeakerUI activeSpeakerUI,
        SpeakerUI inactiveSpeakerUI,
        string text)
    {
        Panel.SetActive(true);
        Time.timeScale = 0;

        activeSpeakerUI.Dialog = text;
        activeSpeakerUI.Dialog = "";

        activeSpeakerUI.Show();
        inactiveSpeakerUI.Hide();

        StopAllCoroutines();
        StartCoroutine(EffectTypewriter(text, activeSpeakerUI));
    }


    private IEnumerator EffectTypewriter(string text, SpeakerUI controller)
    {
        foreach (char character in text.ToCharArray())
        {
            controller.Dialog += character;
            yield return null;
        }
        FinishedLine = true;
    }

    [SerializeField] private UnityEvent myTrigger = null;
    private void probando()
    {
        myTrigger.Invoke();
    }

    private void EndConversation()
    {
        if (conversation.FinalConversation != null)
        {
            if (conversation.EndedDialogo)
            {
                ChangeConversation(conversation.FinalConversation);
            }
        }
        conversation.EndedDialogo = true;
        conversationStarted = false;
        speakerUILeft.Hide();
        speakerUIRight.Hide();
        Panel.SetActive(false);
        activeLineIndex = 1;
        VecesDialogo++;
        if (VecesDialogo <= 1)
        {
            probando();
        }
        Time.timeScale = 1f;
    }
}
using UnityEngine;
using UnityEngine.UI;

public class SpeakerUI : MonoBehaviour
{
    public Image portrait;
    public Text fullName;
    public Text dialog;

    private Character speaker;

    public string Dialog
    {
        get { return dialog.text; }
        set { dialog.text = value; }
    }

    public Character Speaker
    {
        get { return speaker; }
        set
        {
            if(value != null)
            {
                speaker = value;
            }
            if(speaker.portrait != null)
            {
                portrait.sprite = speaker.portrait;
            }
            if (speaker.fullName != null)
            {
                fullName.text = speaker.fullName;
            }
        }
    }
    
    public bool HasSpeaker()
    {
        return speaker != null;
    }

    public bool SpeakerIs(Character character)
    {
        return speaker == character;
    }

    public GameObject dialogPanel;
    public GameObject namePanel;

    [SerializeField]
    private Color colorToTurnTo = Color.white;

    public void Show()
    {
        portrait.GetComponent<Image>().color = Color.white;
        dialogPanel.SetActive(true);
        namePanel.SetActive(true);
        //gameObject.SetActive(true);
    }

    public void Hide()
    {
        portrait.GetComponent<Image>().color = colorToTurnTo;
        dialogPanel.SetActive(false);
        namePanel.SetActive(false);
        //gameObject.SetActive(false);
    }
}
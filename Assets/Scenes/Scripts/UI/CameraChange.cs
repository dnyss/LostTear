using UnityEngine;
using Cinemachine;

public class CameraChange : MonoBehaviour
{
    [SerializeField]
    private CinemachineVirtualCamera vcam1;

    [SerializeField]
    private CinemachineVirtualCamera vcam2;

    private bool maincamera = true;
    private GameObject action;

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "player")
        {
            SwitchPriority();
            maincamera = false;
        }
    }
    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "player")
        {
            SwitchPriority();
            maincamera = true;
        }
    }

    private void SwitchPriority()
    {
        if (maincamera)
        {
            vcam1.Priority = 1;
            vcam2.Priority = 0;
        }
        else
        {
            vcam1.Priority = 0;
            vcam2.Priority = 1;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;
using UnityEngine.XR.Interaction.Toolkit;

public class PushOpenDoor : MonoBehaviour
{
    public Animator animator;
    public string boolName = "open";

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<XRPushButton>().onValueChange.AddListener(x => ToggleDoorOpen());
    }

    public void ToggleDoorOpen()
    {
        animator.SetBool(boolName, !animator.GetBool(boolName));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

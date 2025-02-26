using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerZone : MonoBehaviour
{
    
    public string targetTag;    // The tag of the object that can trigger the event
    public UnityEvent<GameObject> OnEnterEvent; // The event that will be invoked when the object enters the trigger

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that entered the trigger has the target tag
        if (other.gameObject.tag == targetTag)
        {
            // Invoke the event
            OnEnterEvent.Invoke(other.gameObject);
        }
    }
}

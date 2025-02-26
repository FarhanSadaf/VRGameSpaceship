using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCan : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Get the TriggerZone component from the GameObject and add a listener to the OnEnterEvent
        GetComponent<TriggerZone>().OnEnterEvent.AddListener(InsideTrash);
    }

    public void InsideTrash(GameObject obj)
    {
        obj.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour
{
    public List<GameObject> breakableParts;

    public float timeToBreak = 1; // 1 seconds
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        // Disable the breakableParts
        foreach (var item in breakableParts)
        {
            item.SetActive(false);
        }
    }

    public void Break()
    {
        timer += Time.deltaTime;
        
        if (timer > timeToBreak)
        {
            // Enable the breakableParts
            foreach (var item in breakableParts)
            {
                item.SetActive(true);
                item.transform.parent = null;
            }

            gameObject.SetActive(false);    

            timer = 0;
        }
    }
}

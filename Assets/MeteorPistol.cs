using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class MeteorPistol : MonoBehaviour
{
    public ParticleSystem particles;

    public LayerMask layerMask;
    public Transform shootSource;
    public float distance = 10;
    private bool shooting = false;

    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener(x => StartShooting());
        grabInteractable.deactivated.AddListener(x => StopShooting());
    }

    void StartShooting()
    {
        particles.Play();
        shooting = true;
    }

    void StopShooting()
    {
        particles.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
        shooting = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (shooting)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(shootSource.position, shootSource.forward, out hit, distance, layerMask))
        {
            /*
            Breakable breakable = hit.collider.GetComponent<Breakable>();
            if (breakable != null)
            {
                breakable.Break();
            }
            */
            // Or 
            hit.transform.gameObject.SendMessage("Break", SendMessageOptions.DontRequireReceiver);
        }
    }
}

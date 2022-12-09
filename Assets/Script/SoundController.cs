using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public Transform cat;

    public GameObject SoundCat;

    public AudioClip AudioCat;

    private void Update()
    {
        if(cat)
        {
            float dist = Vector3.Distance(cat.position, transform.position);
            print("Distance to cat: " + dist);
            if (dist >= 9.8f && dist <= 10.0f)
            {
                Instantiate(SoundCat);
            }
        }
    }
}

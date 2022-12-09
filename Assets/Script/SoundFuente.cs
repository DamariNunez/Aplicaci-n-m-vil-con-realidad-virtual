using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFuente : MonoBehaviour
{
    public Transform cat;

    public GameObject SoundCat;

    public AudioClip AudioCat;

    private void Update()
    {
        if (cat)
        {
            float dist = Vector3.Distance(cat.position, transform.position);
            print("Distance to cat: " + dist);
            if (dist >= 39.8f && dist <= 40.0f)
            {
                Instantiate(SoundCat);
            }
        }
    }
}

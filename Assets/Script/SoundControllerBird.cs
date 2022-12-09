using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControllerBird : MonoBehaviour
{
    public Transform bird;

    public GameObject SoundBird;

    public AudioClip AudioBird;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bird)
        {
            float dist = Vector3.Distance(bird.position, transform.position);
            print("Distance to bird: " + dist);
            if (dist >= 9.8f && dist <= 10.1f)
            {
                Instantiate(SoundBird);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControllerDog : MonoBehaviour
{
    public Transform dog;

    public GameObject SoundDog;

    public AudioClip AudioDog;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dog)
        {
            float dist = Vector3.Distance(dog.position, transform.position);
            print("Distance to dog: " + dist);
            if (dist >= 9.8f && dist <= 10.0f)
            {
                Instantiate(SoundDog);
            }
        }
    }
}

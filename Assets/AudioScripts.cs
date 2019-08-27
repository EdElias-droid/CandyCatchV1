using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScripts : MonoBehaviour
{

    public AudioClip MusicClip;
    public AudioSource MusicSource;

    // Start is called before the first frame update
    void Start()
    {
        MusicSource.clip = MusicClip;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        MusicSource.Play();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    public AudioSource intro, ghostNormal;
    // Start is called before the first frame update

    void Awake()
    {

    }

    void Start()
    {
        intro.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(intro.isPlaying == false && ghostNormal.isPlaying == false)
        {
            ghostNormal.Play();
            ghostNormal.loop = true;
        }
    }
}

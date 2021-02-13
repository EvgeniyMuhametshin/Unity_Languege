using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeSound : MonoBehaviour
{
    private AudioSource _audioSource;
    private float _soundVolume = 1f;

    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        _audioSource.volume = _soundVolume;
    }

    public void SetVolume(float vol)
    {
        _soundVolume = vol;
    }
}

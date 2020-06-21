using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {
    public AudioSource[] fallsIntoWater;
    public void PlayRandomDestroyNoise() {
        if (fallsIntoWater.Length != 0) {
            // Choose a random number
            // int clipToPlay = Random.Range(0, fallsIntoWater.Length);
            // Play clip
            fallsIntoWater[0].Play();
        }

    }
}

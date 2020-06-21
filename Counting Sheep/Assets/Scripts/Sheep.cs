using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sheep : MonoBehaviour {

    public GameObject sheepPrefab;
    public GameObject destroyEffect;
    public float destroyDelay;

    private SoundManager soundManager;
    private GameObject sheep;
    private CountSheep countSheep;
    private bool canCreate;

    void Start() {
        soundManager = FindObjectOfType<SoundManager>();
        countSheep = FindObjectOfType<CountSheep>();
        canCreate = true;
    }
    void Update() {
        if (sheepPrefab != null && sheep != null && sheep.transform.position.x == -6.49f && sheep.transform.position.y == -0.78f) {
            Destroy(sheep);
            Vector2 position = new Vector2(-6.5f, -0.85f);
            soundManager.PlayRandomDestroyNoise();
            GameObject particle = Instantiate(destroyEffect, position, Quaternion.identity);
            Destroy(particle, destroyDelay);
            canCreate = true;
        }
        Screen.sleepTimeout = SleepTimeout.SystemSetting;
    }

    public void CreateSheep() {
        if (sheepPrefab != null && canCreate == true) {
            Vector2 position = new Vector2(-1.14f, -0.45f);
            sheep = Instantiate(sheepPrefab, position, Quaternion.identity);
            canCreate = false;
            countSheep.IncreaseNumber();
        }
    }
}

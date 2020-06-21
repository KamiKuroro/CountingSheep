using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountSheep : MonoBehaviour {

    public Text numberOfSheeps;
    private int number;

    private void Update() {
        numberOfSheeps.text = "" + number;
    }

    public void IncreaseNumber() {
        number++;
    }
}

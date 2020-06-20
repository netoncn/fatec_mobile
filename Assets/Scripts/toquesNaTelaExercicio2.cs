using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class toquesNaTelaExercicio2 : MonoBehaviour {

	int toquesQtd = 0;
	public TextMeshProUGUI texto;

    // Update is called once per frame
    void Update() {
        Touch touch = Input.GetTouch(0);
        if (touch.phase == TouchPhase.Began) {
            if (touch.position.x < Screen.width/2) {
                toquesQtd--;
                texto.text = toquesQtd.ToString();
            } else if (touch.position.x > Screen.width/2) {
                toquesQtd++;
                texto.text = toquesQtd.ToString();
            }
        }
    }
}

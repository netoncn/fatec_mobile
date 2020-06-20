using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class toquesNaTelaExercicio1 : MonoBehaviour {

	int toquesQtd = 0;
	public TextMeshProUGUI texto;

    // Update is called once per frame
    void Update() {
        if (Input.GetTouch(0).phase == TouchPhase.Began) {
            toquesQtd++;
		    texto.text = toquesQtd.ToString();
        }
    }
}

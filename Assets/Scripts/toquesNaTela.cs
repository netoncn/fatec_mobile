using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toquesNaTela : MonoBehaviour
{

	int toquesQtd = 0;
	public Text texto;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetTouch(0).phase == TouchPhase.Began)
        {
            toquesQtd++;
		    texto.text = toquesQtd.ToString();
        }
    }
}

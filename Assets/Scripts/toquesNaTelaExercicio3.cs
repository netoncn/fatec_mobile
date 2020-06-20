using System.Collections;
using UnityEngine;

public class toquesNaTelaExercicio3 : MonoBehaviour {

	int toquesQtd = 0;
	public GameObject sphere;

    // Update is called once per frame
    void Update() {
        Touch touch = Input.GetTouch(0);
        if (touch.phase == TouchPhase.Began) {
            GameObject newSphere = Instantiate(sphere, new Vector3(0,5,0), Quaternion.identity);
        }
    }

    IEnumerator DestroySphere (GameObject newSphere) {
        yield return new WaitForSeconds(5);
        Destroy(newSphere);
    }
}

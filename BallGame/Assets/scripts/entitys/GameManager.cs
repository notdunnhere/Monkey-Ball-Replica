using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gameIsOver = false;

	// Use this for initialization
	public void EndGame () {

        if (gameIsOver == false) {

            gameIsOver = true;

        }

        Restart();

	}


    void Restart() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Canvas.ForceUpdateCanvases();
    }


}

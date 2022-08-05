using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Goal : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D colInfo) {
        if (colInfo.tag == "Player") {
            Debug.Log("YOW WON");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }

    }


}//Class

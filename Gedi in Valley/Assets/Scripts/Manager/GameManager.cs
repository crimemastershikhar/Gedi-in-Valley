using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    private void OnTriggerEnter2D() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

















}//Class

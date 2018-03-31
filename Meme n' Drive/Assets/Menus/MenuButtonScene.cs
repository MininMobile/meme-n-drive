using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonScene : MonoBehaviour {
    bool moved = false;
    string scene;

    void OnMouseOver() {
        if (!moved) {
            transform.Translate(1, 0, 0);
            moved = true;
        }
    }
    void OnMouseExit() {
        if (moved) {
            transform.Translate(-1, 0, 0);
            moved = false;
        }
    }
    void OnMouseUp() {
        SceneManager.LoadScene(scene);
    }
}

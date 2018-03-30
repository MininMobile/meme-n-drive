using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonScene : MonoBehaviour {
    bool moved = false;

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
}

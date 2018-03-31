using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonPrefab : MonoBehaviour {
    public GameObject prefab;
    public bool enabled = true;

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
    void OnMouseUp() {
        if (enabled) Instantiate(prefab);
    }
}

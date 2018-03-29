using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton : MonoBehaviour {
    void OnMouseOver() {
        Debug.Log(".o.");
        transform.Translate(
            1,
            0,
            0
        );
    }
    void OnMouseExit() {
        Debug.Log(";-;");
        transform.Translate(
            -1,
            0,
            0
        );
    }
}

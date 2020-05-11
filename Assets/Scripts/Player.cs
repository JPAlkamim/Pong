using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public KeyCode UP;
    public KeyCode DOWN;

    public float speed;

    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKey (UP)) {
            GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, speed);
        } else if (Input.GetKey (DOWN)) {
            GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, -speed);
        } else {
            GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);
        }

    }
}
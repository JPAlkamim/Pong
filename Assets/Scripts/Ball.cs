using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour {

    public Player player1;
    public Player player2;
    public Text score1;
    public Text score2;

    private int _1 = 0;
    private int _2 = 0;

    public Rigidbody2D body;
    // Start is called before the first frame update
    void Start () {
        body = GetComponent<Rigidbody2D> ();
        body.velocity = new Vector2 (3, Random.Range (-3, 3));
    }

    // Update is called once per frame
    void Update () {
        body.velocity = new Vector2 (Mathf.Sign (body.velocity.x) * 3, Mathf.Sign (body.velocity.y) * 2);

        if (transform.position.x < player1.transform.position.x) {
            score2.text = _2++.ToString ();

            transform.position = new Vector2 (0, 0);
        }

        if (transform.position.x > player2.transform.position.x) {
            score1.text = _1++.ToString ();

            transform.position = new Vector2 (0, 0);
        }
    }
}
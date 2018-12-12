using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muerte : MonoBehaviour {

    GameManager gm;

    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gm.reiniciar();
        }
    }
}

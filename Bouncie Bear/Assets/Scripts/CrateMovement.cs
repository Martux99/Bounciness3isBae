using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateMovement : MonoBehaviour {

    public bool mov;
    public Rigidbody2D rb;

	void Start () {
        int brandom = Random.Range(0, 2);
        if (brandom == 0)
            mov = false;
        else
        {
            StartCoroutine(move());
            mov = true;
            this.transform.position = new Vector3(0, transform.position.y, transform.position.z);
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator move()
    {
        while (true)
        {
            rb.velocity = new Vector2(2, 0);
            yield return new WaitForSeconds(1.5f);
            rb.velocity = new Vector2(-2, 0);
            yield return new WaitForSeconds(1.5f);
        }
    }
}

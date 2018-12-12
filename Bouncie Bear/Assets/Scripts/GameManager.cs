using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    GameObject player;
    public float lastCrate;
    public GameObject Crate;
    public GameObject crate45;
    public GameObject crateminus45;
    public GameObject crateParedDere;
    public GameObject crateParedIzq;
    bool arreglado = false;

	void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        if (player.transform.position.y < lastCrate - 3)
        {
            reiniciar();
        }
	}
    public void reiniciar()
    {
        SceneManager.LoadScene("Marco 1");
    }
    public void generateCrate(float posx,float posy,GameObject anterior)
    {
        float randy = Random.Range(-2f, 2f);
        int brandom = Random.Range(0, 3);

        if ((randy > posx - 0.5f && randy<0) || (randy < posx + 0.5f && randy>0))
        {
            if (randy < 0)
            {
                randy = 1.8f;
            }
            else
                randy = -1.8f;
        }
        if (brandom == 0)
        {
            Instantiate(Crate, new Vector2(randy, posy+4.0f), transform.rotation);
        }
        if (brandom == 1)
        {
            if (randy > 0)
                Instantiate(crate45, new Vector2(randy, posy + 4.0f), crate45.transform.rotation);
            if (randy < 0)
                Instantiate(crateminus45, new Vector2(randy, posy + 4.0f), crateminus45.transform.rotation);
        }
        if (brandom == 2)
        {
            if (randy > 0)
                Instantiate(crateParedDere, new Vector2(-0.65f, posy + 4.0f), transform.rotation);
            if (randy < 0)
                Instantiate(crateParedIzq, new Vector2(0.65f, posy + 4.0f), transform.rotation);
        }
        Debug.Log(brandom);
    }
}

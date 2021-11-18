using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{

    public int score;
    public float timer;
    public static GameMaster instance;
    public GameObject jugadorPrefab;
    public GameObject meta;
    public GameObject jugador;
    public Vector3 posicion;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        score = 0;
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime * Time.timeScale;
        //Debug.Log(timer);
    }

    public void Pausar(bool pausado)
    {
        if (pausado)
        {
            Time.timeScale = 0;
            Destroy(jugador);
        }
        else
        {
            Time.timeScale = 1;
            if(jugador == null)
            {
                reiniciarJugador();
            }
            if(Input.GetKeyDown(KeyCode.I))
            {
                reiniciarJugador();

            }
        }
    }
    public void reiniciarJugador()
    {
        Destroy(jugador);
        jugador = Instantiate(jugadorPrefab, meta.transform.position, Quaternion.identity);

    }
}

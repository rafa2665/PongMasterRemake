using UnityEngine;
using System.Collections;
[RequireComponent(typeof(Rigidbody2D))]
public class BolaVel : MonoBehaviour {
    Rigidbody2D rb2d;
    GameObject inimigo;
    [SerializeField]
    UnityEngine.UI.Text pontosPlayerTXT, pontosInimigoTXT;
    int pontosPlayer, pontosInimigo = 0;
    void Start()
    {
        inimigo = GameObject.Find("PaletaInimigo");
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(5, 5);
    }

    void Update()
    {
        inimigo.transform.position = new Vector2(inimigo.transform.position.x, -transform.position.y);
        pontosInimigoTXT.text = "Pontos Inimigo: " + pontosInimigo.ToString();
        pontosPlayerTXT.text = "PontosPlayer: " + pontosPlayer.ToString();
    }

    void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.name == "Col4")
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, -5);
            pontosPlayer += 1;
            pontosInimigoTXT.text = "Pontos Inimigo: " + pontosInimigo.ToString();
            pontosPlayerTXT.text = "PontosPlayer: " + pontosPlayer.ToString();
        }
        else if (outro.name == "Col2")
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, 5);
            pontosInimigo += 1;
            pontosInimigoTXT.text = "Pontos Inimigo: " + pontosInimigo.ToString();
            pontosPlayerTXT.text = "PontosPlayer: " + pontosPlayer.ToString();
        }
        else if (outro.name == "Col1")
        {
            rb2d.velocity = new Vector2(5, rb2d.velocity.y);
            pontosInimigoTXT.text = "Pontos Inimigo: " + pontosInimigo.ToString();
            pontosPlayerTXT.text = "PontosPlayer: " + pontosPlayer.ToString();
        }
        else if (outro.name == "Col3")
        {
            rb2d.velocity = new Vector2(-5, rb2d.velocity.y);
            pontosInimigoTXT.text = "Pontos Inimigo: " + pontosInimigo.ToString();
            pontosPlayerTXT.text = "PontosPlayer: " + pontosPlayer.ToString();
        }
    }
}

using UnityEngine;
using System.Collections;
[RequireComponent(typeof(Rigidbody2D))]
public class PaletaMov : MonoBehaviour {
    Rigidbody2D rb2d;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb2d.velocity = new Vector2(0, Input.GetAxisRaw("Vertical") * 5);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public Sprite[] sprites;
    private SpriteRenderer _spriteRenderer;

    private Rigidbody2D _rigidbody;

    public float size = 1.0f;

    public float minSize = 0.5f;

    public float maxSize = 1.5f;

    private void Awake() {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Start(){
        _spriteRenderer.sprite = sprites[Random.Range(0, sprites.Length)];

        // spawn at different rotation angles
        this.transform.eulerAngles = new Vector3(0.0f, 0.0f, Random.value * 360.0f);

        // vector(this.size, this.size, this.size);
        this.transform.localScale = Vector3.one  * this.size;

        _rigidbody.mass = this.size;
    }
}

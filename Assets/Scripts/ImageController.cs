using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageController : MonoBehaviour
{
    private Transform _compTransform;
    private SpriteRenderer _compSpriteRend;
    private int velocidad;
    private int direccionX;
    private int direccionY;
    void Awake()
    {
        _compTransform = GetComponent<Transform>();
        _compSpriteRend = GetComponent<SpriteRenderer>();
        velocidad = 10;
        direccionX = 1;
        direccionY = 1;
    }

    void Update()
    {
        _compTransform.position = new Vector2(_compTransform.position.x + velocidad * direccionX * Time.deltaTime, _compTransform.position.y + velocidad * direccionY * Time.deltaTime);
        if (_compTransform.position.x > 7.98f)
        {
            direccionX = -1;
            _compSpriteRend.flipX = true;
        }
        if (_compTransform.position.x < -7.98f)
        {
            direccionX = 1;
            _compSpriteRend.flipX = false;
        }
        if (_compTransform.position.y > 3.539f)
        {
            direccionY = -1;
            _compSpriteRend.flipY = true;
        }
        if (_compTransform.position.y < -3.539f)
        {
            direccionY = 1;
            _compSpriteRend.flipY = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public Vector3 objectPosition = new Vector3(2, 6, 2);
    public Vector3 objectSize = Vector3.one * 1.3f;

    void Start()
    {
        transform.position = objectPosition;
        transform.localScale = objectSize;
        
        Material material = Renderer.material;
        
        material.color = new Color(
        Random.Range(0.2f, 0.9f),
        Random.Range(0.1f, 0.4f),
        Random.Range(0.5f, 0.9f),
        Random.Range(0.5f, 0.6f)
        );
    }
    
    void Update()
    {
        transform.Rotate(
            Random.Range(5f, 15f)
            * Time.deltaTime, 
            Random.Range(1f, 5f), 
            0
            );
    }
}

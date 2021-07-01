using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    // Random Spawn
    public float spanwZRange = 3;
    public float spanwYRange = 3;
    public float spanwXRange = 3;

    // Random Scale
    public int scaleMinRange = 1;
    public int scaleMaxRange = 5;

    // Random Rotation
    public float rotationMinRange = 0.0001f;
    public float rotationMaxRange = 0.0002f;

    // Random Rotation Speed
    public float rotationMinSpeed = 0.0001f;
    public float rotationMaxSpeed = 0.0003f;
    void Start()
    {
        RandomSpawn();
        RandomScale();
        RandomColor();        
    }

    void Update()
    {
        RandomRotation();
        RandomColor();
    }

    private void RandomSpawn()
    {
        // Random coordinates
        float spanwX = Random.Range(-spanwXRange, spanwXRange);
        float spanwY = Random.Range(-spanwYRange, spanwYRange);
        float spanwZ = Random.Range(-spanwZRange, spanwZRange);

        // Set the new coordinates
        transform.position = new Vector3(spanwX, spanwY, spanwZ);
    }

    private void RandomScale()
    {
        int scale = Random.Range(scaleMinRange, scaleMaxRange);
        transform.localScale = Vector3.one * scale;
    }

    private void RandomRotation()
    {
        float rotationX = Random.Range(rotationMinRange, rotationMaxRange);
        float speedRotration = Random.Range(rotationMinSpeed, rotationMaxSpeed);
        
        transform.Rotate(rotationX * Time.deltaTime * speedRotration, 0, 0);
    }

    private void RandomColor()
    {
        Material material = Renderer.material;

        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        float a = Random.Range(0f, 1f);

        material.color = new Color(r, g, b, a);
    }
}

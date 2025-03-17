using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private int xyz;
    private float speed;
    public MeshRenderer Renderer;
    private Material material;
    private float timer;
    [SerializeField] float changeTime;
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
        xyz = Random.Range(0, 3);
        speed = Random.Range(5.0f, 50.0f);
        material = Renderer.material;

        material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);
    }

    void Update()
    {
        float x = 0f, y = 0f, z = 0f;
        switch (xyz)
        {
            case 0:
                {
                    x = speed * Time.deltaTime;
                }
                break;
            case 1:
                {
                    y = speed * Time.deltaTime;
                }
                break;
            case 2:
                {

                    z = speed * Time.deltaTime;
                }
                break;
        }
        transform.Rotate(x, y, z);

        /*
        r += 0.1f;
        if(r>1.0f) r = 0.0f;
        Render.material.color = new color(r,g,b, 0.4f);
        */
        

    }
}

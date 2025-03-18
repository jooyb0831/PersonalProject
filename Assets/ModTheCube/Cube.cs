using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class Cube : MonoBehaviour
{
    private int xyz;
    private float r, g, b;
    private bool br, bg, bb;
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

        r = 0.5f;
        g = 1.0f;
        b = 0.3f;
        br = true;
        bg = true;
        bb = false;
        material.color = new Color(r, g, b, 1.0f);

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

        ChangeColor(ref br, ref r, 0.04f * Time.deltaTime);
        ChangeColor(ref bg, ref g, 0.05f * Time.deltaTime);
        ChangeColor(ref bb, ref b, 0.06f * Time.deltaTime);
        Renderer.material.color = new Color(r, g, b, 1.0f);


    }

    private void ChangeColor(ref bool isAdd, ref float col, float val)
    {
        if (isAdd)
        {
            col += val;
            if (col > 1.0f)
            {
                col = 1.0f;
                isAdd = false;
            }
        }
        else
        {
            col -= val;
            if (col < 0f)
            {
                col = 0f;
                isAdd = true;
            }
        }

    }
}

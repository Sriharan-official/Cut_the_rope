using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : MonoBehaviour
{
    public Rigidbody2D hook;

    public Weight weight;

    public GameObject linkprefab;

    public int links = 7;

    void Start()
    {
        GenerateRope();
    }

    void GenerateRope()
    {
        Rigidbody2D previousrb = hook;
        for (int i = 0; i < links; i++)
        {
            GameObject link = Instantiate(linkprefab, transform);
            HingeJoint2D joint = link.GetComponent<HingeJoint2D>();
            joint.connectedBody = previousrb;

            if (i < links - 1)
            {
                previousrb = link.GetComponent<Rigidbody2D>();
            }
            else
            {
                weight.Connectrope(link.GetComponent<Rigidbody2D>());
            }

        }
    }

   
}

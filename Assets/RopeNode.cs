using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeNode : MonoBehaviour
{
    public Rigidbody rb;
    public SpringJoint spring;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        spring = GetComponent<SpringJoint>();
    }
}

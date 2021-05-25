using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weight : MonoBehaviour
{
    public float distancefromchain = 0.6f;
    public void Connectrope(Rigidbody2D endrb)
    {
        HingeJoint2D joint =  gameObject.AddComponent<HingeJoint2D>();
        joint.autoConfigureConnectedAnchor = false;
        joint.connectedBody = endrb;
        joint.anchor = Vector2.zero;
        joint.connectedAnchor = new Vector2(0f, distancefromchain);
    }
}

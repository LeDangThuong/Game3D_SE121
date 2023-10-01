using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{ 
    public Transform target;
    public Transform move;

    // Start is called before the first frame update
    void Start()
    {
        move = transform;
        move.localPosition = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

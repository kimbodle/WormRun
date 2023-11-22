using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground_move : MonoBehaviour
{
    public float ground_speed = 5f;

    void Moveleft_ground()
    {
        transform.Translate(Vector3.left * ground_speed * Time.deltaTime);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Moveleft_ground();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Rigidbody2D rb;
    public int jumppower;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void CharacterJump()
    {
        // ���� ���� y�� ������ �ӵ��� 0���� ����ϴ�.
        rb.velocity = new Vector2(rb.velocity.x, 0);
        rb.AddForce(Vector2.up * jumppower, ForceMode2D.Impulse);
       
    }
}

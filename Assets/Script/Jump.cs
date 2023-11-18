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
    //public void CharacterJump()
    //{
    //    rb.AddForce(Vector2.up * jumppower);//Time.deltaTime);
    //
    //    Debug.Log("jump");
    //}
    // Double Jump 하고싶다 점프 두번만 하게 하는거
    public void CharacterJump()
    {
        rb.AddForce(Vector2.up * jumppower, ForceMode2D.Impulse);
        /*
        if (Input.GetButtonDown("Jump") && (anim.GetInteger("isJump") == 0))
        {
            rigid.AddForce(Vector2.up* jumpPower, ForceMode2D.Impulse);
             anim.SetInteger("isJump", 1);
        }
        else if (Input.GetButtonDown("Jump") && (anim.GetInteger("isJump") == 1))
        {
             rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
         anim.SetInteger("isJump", 2);
           }

    // Landinf Platfrom
    if (rigid.velocity.y < 0)
    {
        Debug.DrawRay(rigid.position, Vector3.down, new Color(0, 1, 0));
        RaycastHit2D rayHit = Physics2D.Raycast(rigid.position, Vector3.down, 1, LayerMask.GetMask("Platform"));
        if (rayHit.collider != null)
        {
            if (rayHit.distance < 0.5f)
                anim.SetInteger("isJump", 0);
        }
    }*/
    }
}

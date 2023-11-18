using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger : MonoBehaviour
{
    public Score_test score_Test;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("부딫침");
        score_Test.score++;

        if (collision.transform.tag == "Skill")
        {
            Destroy(gameObject);
            Debug.Log("스킬 닿음");
        }

    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if(collision.transform.tag == "Skill")
    //    {
    //        Destroy(gameObject);
    //    }   
    //}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger : MonoBehaviour
{
    public Score_test score_Test;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("�΋Hħ");
        score_Test.score++;

        if (collision.transform.tag == "Skill")
        {
            Destroy(gameObject);
            Debug.Log("��ų ����");
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

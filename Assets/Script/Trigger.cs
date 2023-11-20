using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger : MonoBehaviour
{
    public Score_test score_Test;
    public float speed = 5f;
    void MoveLeft()
    {
        // 현재 위치를 가져와서 왼쪽으로 이동
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    void Update()
    {
        // 왼쪽으로 이동
        MoveLeft();
    }

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
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger3 : MonoBehaviour
{
    public AudioSource audioSource;
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
        audioSource.Play();

        if (collision.transform.tag == "Player")
        {
            Destroy(gameObject);
            Debug.Log("스킬3 닿음");
            score_Test.score++;
        }
        else
        {
            Debug.Log("적에 맞는 스킬을 사용해주세요");
        }
    }
}

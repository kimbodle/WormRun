using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger1 : MonoBehaviour
{
    public AudioSource audioSource;

    public Score_test score_Test;
    public float speed = 5f;

    // UI Text 요소
    public Text infoText;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

        infoText = GameObject.Find("SkillError").GetComponent<Text>();
        // YourUITextObjectName은 텍스트를 표시할 UI Text 오브젝트의 이름입니다.
    }
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


        if (collision.transform.tag == "Skill1")
        {
            Destroy(gameObject);
            Debug.Log("스킬 닿음");
            score_Test.score++;

            // 텍스트 업데이트
            infoText.text = "승리! 스코어: " + score_Test.score;
        }
        else {
            Debug.Log("적에 맞는 스킬을 사용해주세요");
            // 텍스트 업데이트
            infoText.text = "적에 맞는 스킬을 사용해주세요";
        }
    }
}

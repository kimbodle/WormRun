using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Trigger3 : MonoBehaviour
{
    public AudioSource audioSource;
    public Score_test score_Test;
    public float speed = 5f;
    public Text infoText;
    private void Start()
    {
        infoText = GameObject.Find("SkillError").GetComponent<Text>();
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
        if (score_Test.score == 10)
        {
            SceneManager.LoadScene("GameClear");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("부딫침");
        audioSource.Play();

        if (collision.transform.tag == "Player")
        {
            Debug.Log("스킬 닿음");
            score_Test.score++;
            infoText.text = "스킬 성공! 스코어: " + score_Test.score;
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;
            StartCoroutine(WaitAndDestroy(1f));
        }
        else
        {
            Debug.Log("적에 맞는 스킬을 사용해주세요");
            infoText.text = "적에 맞는 스킬을 사용해주세요";
            StartCoroutine(WaitAndClearText(1f));
        }
    }

    IEnumerator WaitAndDestroy(float duration)
    {
        yield return new WaitForSeconds(duration);
        infoText.text = " ";
        Destroy(gameObject);
    }

    IEnumerator WaitAndClearText(float duration)
    {
        yield return new WaitForSeconds(duration);
        infoText.text = " ";
    }
}
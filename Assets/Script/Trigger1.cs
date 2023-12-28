using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Trigger1 : MonoBehaviour
{
    public AudioSource audioSource;
    public Score_test score_Test;
    public float speed = 5f;
    public Text infoText;

    private void Start()
    {
        //audioSource = GetComponent<AudioSource>(); 프리베잇으로 할때
        infoText = GameObject.Find("SkillError").GetComponent<Text>();
    }

    void MoveLeft()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    void Update()
    {
        MoveLeft();
        if(score_Test.score == 10)
        {
            SceneManager.LoadScene("GameClear");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("부딫침");

        if (collision.transform.tag == "Skill1")
        {
            Debug.Log("스킬 닿음");
            score_Test.score++;
            infoText.text = "스킬 성공! 스코어: " + score_Test.score;
            audioSource.Play();
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

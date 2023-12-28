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
        //audioSource = GetComponent<AudioSource>(); ������������ �Ҷ�
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
        Debug.Log("�΋Hħ");

        if (collision.transform.tag == "Skill1")
        {
            Debug.Log("��ų ����");
            score_Test.score++;
            infoText.text = "��ų ����! ���ھ�: " + score_Test.score;
            audioSource.Play();
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;
            StartCoroutine(WaitAndDestroy(1f));
        }
        else
        {
            Debug.Log("���� �´� ��ų�� ������ּ���");
            infoText.text = "���� �´� ��ų�� ������ּ���";
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

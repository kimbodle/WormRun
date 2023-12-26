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
        // ���� ��ġ�� �����ͼ� �������� �̵�
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    void Update()
    {
        // �������� �̵�
        MoveLeft();
        if (score_Test.score == 10)
        {
            SceneManager.LoadScene("GameClear");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("�΋Hħ");
        audioSource.Play();

        if (collision.transform.tag == "Player")
        {
            Debug.Log("��ų ����");
            score_Test.score++;
            infoText.text = "��ų ����! ���ھ�: " + score_Test.score;
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
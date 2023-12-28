using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Endig : MonoBehaviour
{
    public float delay = 0.3f; // ���ڰ� ��Ÿ���� ������ �ð�
    public string fullText = " �ϳ� ���� �ð��� ��ȴ�.. \n ���� ���� ���ִ� ���� �� �� �־�! "; // ��ü �ؽ�Ʈ
    private string currentText = ""; // ���� �ؽ�Ʈ
    public Text showText; // �ؽ�Ʈ�� �����ִ� UI ������Ʈ

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShowText());
    }

    IEnumerator ShowText()
    {
        for (int i = 0; i < fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            showText.text = currentText;
            yield return new WaitForSeconds(delay);
        }

        yield return new WaitForSeconds(3); // ��� ���ڰ� ��µ� �� 5�� ���
        Destroy(gameObject);
    }
}

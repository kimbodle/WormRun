using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // �� ������ ���� ���ӽ����̽� �߰�

public class TypingEffect : MonoBehaviour
{
    public float delay = 0.1f; // ���ڰ� ��Ÿ���� ������ �ð�
    public string fullText = " ���� �� �¾ ������.. \n ���ִ� ���� �ǰ� �͵�,,\n �׷����� ������ �Ǳ������ �ʹ� �ְ� ���ϴ�..\n ����� ��,, ����� �� �ʹ� ������Ѵ�..\n 10���� ������ ��� ���� �� ���� ���׾�....\n \n ( 5�ʵ� ���� ���� ) "; // ��ü �ؽ�Ʈ
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
        SceneManager.LoadScene("SampleScene"); // SampleScene���� �Ѿ
    }
}

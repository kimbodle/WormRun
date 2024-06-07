using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // �� ������ ���� ���ӽ����̽� �߰�

public class TypingEffect : MonoBehaviour
{
    public float delay = 0.15f; // ���ڰ� ��Ÿ���� ������ �ð�
    private string fullText = " ���� �� �¾ �ֹ���... \n ���� ���� �Ǵ� ���� ��������,\n �������� �����ϱ������ ������ �ְ� �賭�ϴ�.\n �������� ��, �׸��� ����� ���� ������ �����ϰ� �־�...\n �׷��� 10���� �÷��� �غ��ϰ� ���� �ݵ�� ���� �� ���̴�!\n \n (5�� �� ������ ���۵˴ϴ�) "; // ��ü �ؽ�Ʈ
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

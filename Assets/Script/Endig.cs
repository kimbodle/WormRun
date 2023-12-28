using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Endig : MonoBehaviour
{
    public float delay = 0.3f; // 글자가 나타나는 딜레이 시간
    public string fullText = " 꽤나 많은 시간이 흘렸다.. \n 이제 나도 멋있는 나비가 될 수 있어! "; // 전체 텍스트
    private string currentText = ""; // 현재 텍스트
    public Text showText; // 텍스트를 보여주는 UI 컴포넌트

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

        yield return new WaitForSeconds(3); // 모든 글자가 출력된 후 5초 대기
        Destroy(gameObject);
    }
}

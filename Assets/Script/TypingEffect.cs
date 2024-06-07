using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // 씬 관리를 위한 네임스페이스 추가

public class TypingEffect : MonoBehaviour
{
    public float delay = 0.15f; // 글자가 나타나는 딜레이 시간
    private string fullText = " 나는 막 태어난 애벌레... \n 멋진 나비가 되는 것이 꿈이지만,\n 성충으로 변신하기까지의 여정은 멀고도 험난하다.\n 독수리와 쥐, 그리고 뱀들은 나의 여정을 방해하고 있어...\n 그러나 10번의 시련을 극복하고 나는 반드시 나비가 될 것이다!\n \n (5초 후 게임이 시작됩니다) "; // 전체 텍스트
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
        SceneManager.LoadScene("SampleScene"); // SampleScene으로 넘어감
    }
}

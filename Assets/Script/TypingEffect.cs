using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // 씬 관리를 위한 네임스페이스 추가

public class TypingEffect : MonoBehaviour
{
    public float delay = 0.1f; // 글자가 나타나는 딜레이 시간
    public string fullText = " 나는 갓 태어난 에벌래.. \n 멋있는 나비가 되고 싶따,,\n 그럿지만 성충이 되기까지는 너무 멀고 험하다..\n 새들과 쥐,, 뱀들은 날 너무 힘들게한다..\n 10번의 역경을 딛고 나는 꼭 나비가 될테야....\n \n ( 5초뒤 게임 시작 ) "; // 전체 텍스트
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

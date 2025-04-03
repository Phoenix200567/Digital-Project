using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections;

public class DialogScrollController : MonoBehaviour
{
    /*public List<GameObject> messageList;
 // 拖入所有 xx_message_xx 的 Image（顺序即显示顺序）
    public float delayBetweenMessages = 3f;
    public float moveUpDistance = 160f; // 每条消息的高度，视你UI定
    public float moveDuration = 0.5f;

    private int currentMessageIndex = 0;

    void Start()
    {
        // 初始隐藏所有 message
        foreach (var msg in messageList)
        {
            msg.gameObject.SetActive(false);
        }

        StartCoroutine(RevealMessagesOneByOne());
    }

    IEnumerator RevealMessagesOneByOne()
    {
        while (currentMessageIndex < messageList.Count)
        {
            // 向上移动当前已显示的所有消息
            for (int i = 0; i < currentMessageIndex; i++)
            {
                var rt = messageList[i];
                LeanTween.moveY(rt, rt.anchoredPosition.y + moveUpDistance, moveDuration)
                         .setEase(LeanTweenType.easeInOutQuad);
            }

            yield return new WaitForSeconds(moveDuration); // 等待旧消息腾出空间

            // 显示新消息
            var currentMessage = messageList[currentMessageIndex];
            currentMessage.gameObject.SetActive(true);

            currentMessageIndex++;
            yield return new WaitForSeconds(delayBetweenMessages);
        }
    }
}*/
}

    


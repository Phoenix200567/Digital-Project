using System;
using System.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class ChatDisplay : MonoBehaviour
{
    public GameObject content; // 你要指定 Content 对象
    private float delayTime = 0.5f; // 每条消息显示的延迟时间

    void Start()
    {
        // 启动协程，开始显示消息
        StartCoroutine(DisplayMessages());
    }

    private IEnumerator DisplayMessages()
    {
        // 获取所有 "Panel_message" 子物体 (RectTransform)
        RectTransform[] messages = content.GetComponentsInChildren<RectTransform>();

        // 从索引1开始，因为索引0是 Content 本身
        for (int i = 1; i < messages.Length; i++)
        {
            // 获取每个子物体（即每个 "Panel_message")
            GameObject panelMessage = messages[i].gameObject;

            // 确保每个消息一开始是隐藏的
            panelMessage.SetActive(false);
        }

        // 等待2秒钟
        yield return new WaitForSeconds(2.0f);

        // 按顺序显示每个消息
        for (int i = 1; i < messages.Length; i++)
        {
            GameObject panelMessage = messages[i].gameObject;

            // 显示当前消息
            panelMessage.SetActive(true);

            // 等待指定的延迟时间
            if (messages[i].name[0].Equals('P'))
            {
                yield return new WaitForSeconds(delayTime);
            }
            else {
                yield return new WaitForSeconds(0.0f);  // or set a small flat value
            }
        }
    }
}

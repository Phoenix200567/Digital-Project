using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    [Header("UI 元素引用")]
    public GameObject dialogPanel;       // 对话框Panel
    public TextMeshProUGUI dialogText;     // 对话框内的文本
    public Button yesButton;             // “Yes”按钮
    public Button noButton;              // “No”按钮
    public Button triggerButton;         // 用于触发对话框显示的按钮

    // 标记是否等待点击Panel以关闭对话框（仅在“Yes”按钮点击后生效）
   [Header("Post Content 移动目标")]
    public RectTransform postContent;    // post_content 的 RectTransform
    public float moveDistance = 500f;    // 移动距离（根据实际需求调整）
    public float moveDuration = 1f;      // 移动时间（秒）

    private bool waitingForPanelClick = false;



    void Start()
    {
        // 初始隐藏对话框
        dialogPanel.SetActive(false);

        // 为按钮添加监听事件
        triggerButton.onClick.AddListener(ShowDialog);
        yesButton.onClick.AddListener(OnYesClicked);
        noButton.onClick.AddListener(OnNoClicked);
    }

    // 显示对话框并设置初始文本
    void ShowDialog()
    {
        dialogPanel.SetActive(true);
        dialogText.text = "Remove selected post?"; // 可根据需要修改初始提示
        waitingForPanelClick = false;
    }

    // 点击“Yes”按钮后：更新文本并启用点击Panel关闭功能
    void OnYesClicked()
    {
        dialogText.text = "Post remove successful";
        waitingForPanelClick = true;
    }

    // 点击“No”按钮后：直接关闭对话框
    void OnNoClicked()
    {
        CloseDialog();
    }

    // 此方法将在Panel被点击时调用（需通过EventTrigger设置）
    public void OnPanelClick()
    {
        if (waitingForPanelClick)
        {
            CloseDialog();
        }
    }

    // 关闭对话框，隐藏Panel
    void CloseDialog()
    {
        dialogPanel.SetActive(false);
        waitingForPanelClick = false;
    }
     void MovePostContentOut()
    {
        if (postContent == null)
        {
            Debug.LogError("❌ postContent 未正确绑定！");
            return;
        }

        // 计算目标位置 (Y 轴向上移动 moveDistance)
        float targetY = postContent.anchoredPosition.y + moveDistance;

        // 使用 LeanTween 平滑移动
        LeanTween.moveY(postContent, targetY, moveDuration)
                 .setEase(LeanTweenType.easeInOutQuad)  // 平滑动画
                 .setOnComplete(HidePostContent);       // 移动完成后隐藏
    }

    // **滑动完成后隐藏 `post_content`**
    void HidePostContent()
    {
        postContent.gameObject.SetActive(false);
        Debug.Log("✅ post_content 已隐藏！");
    }
}



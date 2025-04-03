using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DemoteDialogManager : MonoBehaviour
{
    [Header("UI 元素引用")]
    public GameObject dialogPanel;       // 对话框Panel
    public TextMeshProUGUI dialogText;     // 对话框内的文本
    public Button yesButton;             // “Yes”按钮
    public Button noButton;              // “No”按钮
    public Button triggerButton;         // 用于触发对话框显示的按钮

    // 标记是否等待点击Panel以关闭对话框（仅在“Yes”按钮点击后生效）
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
        dialogText.text = "Demote selected post?"; // 可根据需要修改初始提示
        waitingForPanelClick = false;
    }

    // 点击“Yes”按钮后：更新文本并启用点击Panel关闭功能
    void OnYesClicked()
    {
        dialogText.text = "Post successfully demote";
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
}

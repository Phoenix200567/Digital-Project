using UnityEngine;

public class ChatControl : MonoBehaviour
{
    public GameObject chatPanel; // message 界面
    public GameObject Chat;    // chat 界面
    public GameObject messageButton; // 控制显示的按钮（主菜单界面）

    private bool isPaused = false;  // 用于追踪界面是否处于暂停状态

    void Update()
    {
        // 检测用户按下了 Esc 键
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            CloseAllPanels(); // 按下 ESC 键时关闭所有界面
        }
    }

    // 控制显示 message 面板
    public void ShowMessagePanel()
    {
        messageButton.SetActive(false); // 隐藏主菜单按钮
        chatPanel.SetActive(true); // 显示 message 面板
    }

    // 控制显示 chat 面板
    public void ShowChatPanel()
    {
        chatPanel.SetActive(false); // 隐藏 message 面板
        Chat.SetActive(true); // 显示 chat 面板
    }

    // 退出当前面板
    public void ExitPanel()
    {
        CloseAllPanels(); // 关闭所有界面
    }

    // 关闭所有面板
    private void CloseAllPanels()
    {
        messageButton.SetActive(false); // 隐藏主菜单
        chatPanel.SetActive(false);  // 隐藏 message 面板
        Chat.SetActive(false);     // 隐藏 chat 面板
    }
}

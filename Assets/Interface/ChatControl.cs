using UnityEngine;



public class ChatControl : MonoBehaviour
{
    public GameObject chatPanel;  // message 界面
    public GameObject chat;     // chat 界面
    public GameObject ButtonExit; // 控制 message 界面的按钮
    

    void Start()
    {
        // 初始化时，隐藏所有界面
        CloseAllPanels();
    }

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
        
        chat.SetActive(true);   // 显示 message 面板
    }

    // 控制显示 chat 面板
    public void ShowChatPanel()
    {
        chatPanel.SetActive(false);  // 隐藏 message 面板
        chat.SetActive(true);      // 显示 chat 面板
    }

    // 退出当前面板
    public void ExitPanel()
    {
        CloseAllPanels(); // 关闭所有界面
    }

    // 关闭所有面板
    private void CloseAllPanels()
    {
        
        chatPanel.SetActive(false);  // 隐藏 message 面板
        chat.SetActive(false);     // 隐藏 chat 面板
    }
}

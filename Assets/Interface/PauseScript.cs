using UnityEngine;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour
{
    public GameObject pausePanel;  // 暂停菜单 UI 面板

    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
                ResumeGame();
            else
                PauseGame();
        }
    }

    public void PauseGame()
    {
        pausePanel.SetActive(true);        // 显示暂停菜单
        Time.timeScale = 0f;              // 游戏暂停
        isPaused = true;
    }

    public void ResumeGame()
    {
        pausePanel.SetActive(false);      // 隐藏暂停菜单
        Time.timeScale = 1f;              // 恢复游戏
        isPaused = false;
    }
}

using UnityEngine;
using UnityEngine.SceneManagement; // 用于场景管理（退出游戏）

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu; // 持有暂停界面的 GameObject
    public GameObject settingsMenu; // 持有设置界面的 GameObject
    public GameObject quitConfirmationMenu; // 持有确认退出界面的 GameObject
    private bool isPaused = false; // 用于追踪暂停状态

    void Update()
    {
        // 检测用户是否按下了 ESC 键
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame(); // 如果当前游戏已暂停，则恢复游戏
            }
            else
            {
                PauseGame(); // 否则，暂停游戏
            }
        }
    }

    // 暂停游戏
    void PauseGame()
    {
        pauseMenu.SetActive(true); // 显示暂停界面
        Time.timeScale = 0f; // 暂停游戏进程
        isPaused = true; // 更新暂停状态
    }

    // 恢复游戏
    void ResumeGame()
    {
        pauseMenu.SetActive(false); // 隐藏暂停界面
        Time.timeScale = 1f; // 恢复游戏进程
        isPaused = false; // 更新暂停状态
        Debug.Log("Resume button clicked!");
    }

    // 显示设置界面
    public void OpenSettings()
    {
        settingsMenu.SetActive(true); // 显示设置界面
        pauseMenu.SetActive(false); // 隐藏暂停界面
    }

    // 返回暂停界面
    public void BackToPauseMenu()
    {
        settingsMenu.SetActive(false); // 隐藏设置界面
        pauseMenu.SetActive(true); // 显示暂停界面
    }

    // 显示退出确认界面
    public void ShowQuitConfirmation()
    {
        quitConfirmationMenu.SetActive(true); // 显示退出确认界面
        pauseMenu.SetActive(false); // 隐藏暂停界面
    }

    // 确认退出游戏
    public void QuitGame()
    {
        Application.Quit(); // 退出游戏
    }

    // 取消退出，返回暂停界面
    public void CancelQuit()
    {
        quitConfirmationMenu.SetActive(false); // 隐藏退出确认界面
        pauseMenu.SetActive(true); // 显示暂停界面
    }
}

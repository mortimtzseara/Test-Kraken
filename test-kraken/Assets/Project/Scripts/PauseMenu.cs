using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject pauseButton;
    void Awake()
    {
		pauseMenu.SetActive(false);
    }
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            if (pauseMenu.activeSelf)
            {
                ClosePause();

			}
            else
            {
				OpenPause();
			}            
        }
    }
    public void OpenPause()
    {
		pauseMenu.SetActive(true);
        pauseButton.SetActive(false);
        Time.timeScale = 0f;
    }
	public void ClosePause()
	{
		pauseMenu.SetActive(false);
		pauseButton.SetActive(true);
		Time.timeScale = 1f;
	}
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeChanger : MonoBehaviour
{

	public Animator animator;

	private int levelToLoad;

    private void Start()
    {	

        if (PlayerPrefs.GetInt("Fade") == 1)
        {
			this.gameObject.SetActive(false);
        }
    }
    void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			FadeToNextLevel();
		}
	}

	public void FadeToNextLevel()
	{
		FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void FadeToLevel(int levelIndex)
	{
		levelToLoad = levelIndex;
		animator.SetTrigger("FadeOut");
	}

	public void OnFadeComplete()
	{
		SceneManager.LoadScene(levelToLoad);
	}
}
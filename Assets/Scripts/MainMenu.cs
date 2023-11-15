using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject _book;
    [SerializeField] RectTransform _bookTransform;
    [SerializeField] float _initialPosition;
    [SerializeField] float _finalPosition; 
    [SerializeField] float _bookSpeed = 5f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Update is called once per frame
    public void QuitGame()
    {
       Application.Quit(); 
    }

    public void GoToSeetingsMenu()
    {
        SceneManager.LoadScene("OptionsMenu");
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void GoToGameMenu()
    {
        SceneManager.LoadScene("GameMenu");
    }

    public void OpenOptions()
    {
        StartCoroutine("Book");
    }

    public void OpenMenu()
    {
        StartCoroutine("ReturnMenu");
    }

    IEnumerator Book()
    {
        
        while (_bookTransform.position.y > _finalPosition)
        {
            _bookTransform.localPosition -= new Vector3(0, 1 * _bookSpeed, 0);
            yield return new WaitForEndOfFrame();
        }

    }

    IEnumerator ReturnMenu()
    {
        while (_bookTransform.position.y <_initialPosition)
        {
            _bookTransform.localPosition += new Vector3(0, 1 * _bookSpeed, 0);
            yield return new WaitForEndOfFrame();
        }
    }
}

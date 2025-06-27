using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [SerializeField] private GameObject gameOverCanvas;
    public static GameManager instance;
    public Character[] characters;
    public Character currentCharacter;



    // Instance e Awake 
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);

        }
        DontDestroyOnLoad(gameObject);
        Time.timeScale = 1f;
    }

    private void Start()
    {
        if (characters.Length > 0)
        {
            currentCharacter = characters[0];
        }
    }

    public void SetCharacter(Character character)
    {
        currentCharacter = character;
    }


    public void GameOver() {
        SceneManager.LoadScene("GameOverScene");
    }
}


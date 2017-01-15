using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    private static GameControl _thisObject;

    void Awake()
    {
        if (_thisObject != null)
        {
            DestroyImmediate(gameObject);
            return;
        }
        _thisObject = this;
        DontDestroyOnLoad(transform.root.gameObject);
    }

    public static void GoToLevel (string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}
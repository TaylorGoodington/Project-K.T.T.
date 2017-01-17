using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    private static GameControl _thisObject;
    public static List<MathNumbers> mathNumbers;

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

    void Start ()
    {
        mathNumbers = new List<MathNumbers>();
        CreateMathNumbersList();
        UpdateNumbersListFromPlayerPrefs();
    }

    public static void GoToLevel (string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    private void CreateMathNumbersList ()
    {
        mathNumbers.Add(new MathNumbers(0, true));
        mathNumbers.Add(new MathNumbers(1, true));
        mathNumbers.Add(new MathNumbers(2, true));
        mathNumbers.Add(new MathNumbers(3, true));
        mathNumbers.Add(new MathNumbers(4, true));
        mathNumbers.Add(new MathNumbers(5, true));
        mathNumbers.Add(new MathNumbers(6, true));
        mathNumbers.Add(new MathNumbers(7, true));
        mathNumbers.Add(new MathNumbers(8, true));
        mathNumbers.Add(new MathNumbers(9, true));
        mathNumbers.Add(new MathNumbers(10, true));
        mathNumbers.Add(new MathNumbers(11, true));
        mathNumbers.Add(new MathNumbers(12, true));
        mathNumbers.Add(new MathNumbers(13, true));
        mathNumbers.Add(new MathNumbers(14, true));
        mathNumbers.Add(new MathNumbers(15, true));
        mathNumbers.Add(new MathNumbers(16, true));
        mathNumbers.Add(new MathNumbers(17, true));
        mathNumbers.Add(new MathNumbers(18, true));
        mathNumbers.Add(new MathNumbers(19, true));
        mathNumbers.Add(new MathNumbers(20, true));
    }

    private void UpdateNumbersListFromPlayerPrefs ()
    {
        foreach (MathNumbers number in mathNumbers)
        {
            number.isInUse = PlayerPrefsManager.GetValueList(number.number.ToString());
        }
    }

    public static void UpdatePlayerPrefsFromNumbersList ()
    {
        foreach (MathNumbers number in mathNumbers)
        {
            PlayerPrefsManager.SetValueList(number.number.ToString(), number.isInUse);
        }
    }
}
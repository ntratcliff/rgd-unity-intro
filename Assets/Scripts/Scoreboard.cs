using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour
{
    /// <summary>
    /// The displayed score
    /// </summary>
    [Tooltip("The displayed score")]
    public int Score;

    /// <summary>
    /// Attached UI Text component
    /// </summary>
    private Text uiText;

    // Awake is called before Start and only once ever
    private void Awake()
    {
        uiText = GetComponent<Text>();
        Score = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        uiText.text = Score.ToString();
    }
}

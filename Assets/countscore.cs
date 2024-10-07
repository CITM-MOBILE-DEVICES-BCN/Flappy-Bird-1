using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Countscore : MonoBehaviour
{
    // Start is called before the first frame update
    private int score = 0;
    private int highscore = 0;
    [SerializeField] private TextMeshProUGUI textUI;
    public void IncreaseScore()
    {
        score++;
        if (score > highscore)
        {
            highscore = score;
            PlayerPrefs.SetInt("HS", highscore);
            PlayerPrefs.Save();
        }
    }

    void Start()
    {
        highscore = PlayerPrefs.GetInt("HS");
    }

    // Update is called once per frame
    void Update()
    {
        




        textUI.text = ("Score: " + score.ToString() + "\nHighScore: " + highscore.ToString());

    }
}

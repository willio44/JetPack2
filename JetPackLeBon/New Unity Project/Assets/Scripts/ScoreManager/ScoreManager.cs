﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
     Text LabelScore;
    int Score;
	// Use this for initialization
	void Start () {
        LabelScore = GetComponent<Text>();
        Score = 0;
        DisplayScore();
    }
    public void AjouterPoints(int nbPoints)
    {
        Score+= nbPoints;
        DisplayScore();
    }
    
    public void DisplayScore()
    {
        LabelScore.text = "Score : " + Score.ToString();
    }

    public int GetScore()
    {
        return this.Score;
    }
}

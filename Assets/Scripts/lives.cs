﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lives : MonoBehaviour {

    public Text LivesText;

    void Update() {
        LivesText.text = gamemanagement.lives.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo
{
    public string name;
    public int score;

    public PlayerInfo (string name)
    {
        this.name = name;
        this.score = 0;
    }
}

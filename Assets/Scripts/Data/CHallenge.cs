using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

[System.Serializable]
public class Challenge
{
    [TextArea(2,4)]
    public string text;
    public int points;
    public ChallengeType type = ChallengeType.Dare;
    public string category;
    public int difficulty = 1;
}

[CreateAssetMenu (fileName = "ChallengeList", menuName = "Tomangi/ChallengeList")]
public class ChallengueList : ScriptableObject
{
    public Challenge[] items;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New PlayerData", menuName = "ScriptablesObjects/Variables/PlayerData")]

public class PlayerData : ScriptableObject
{
    public int maxLifePoints = 3;

    public int currentLifePoints;
}

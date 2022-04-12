using System.Collections.Generic;
using UnityEngine;


public class GameStatus : MonoBehaviour
{
    public string username;

    public int xp;
    public int coins;
    public int skinSelected;
    public List<int> skinsAvailable;
    public int weaponSelected;
    public List<int> weaponsAvailable;

    public int resolutionIndex;
    public bool fullScreen;
    public int qualityIndex;
    public float volume;
}
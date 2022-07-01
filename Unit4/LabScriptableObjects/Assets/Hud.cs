using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Hud", menuName = "Hud")]
public class Hud : ScriptableObject
{
    public int ammoCount;
    public string weaponName;
    public int ammoPotential;
    public int health;


    public Sprite artwork;
}

using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName ="New Item",menuName ="Item/Create New Item")]
public class Item : ScriptableObject
{
    public string ItemName;
    public int Amount;
    public int price;
    //public Sprite Icon;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Car", menuName ="Cards")]
public class CardModel : ScriptableObject
{
    public string title;
    [TextArea(3, 5)]
    public string description;
    [TextArea(3, 5)]
    public string exhibit;
    public Sprite animalImg;
	
}

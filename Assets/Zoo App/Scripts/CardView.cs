using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardView : MonoBehaviour
{
    public Text title;
    public Text description;
    public Text exhibit;
    public Image animalImg;

    public CardModel[] cardModels;

    private CardModel targetCard;

    public void DisplayInfo(int index)
    {
        title.text = cardModels[index].name;
        description.text = cardModels[index].description;
        exhibit.text = cardModels[index].exhibit;
        animalImg.sprite = cardModels[index].animalImg;
    }


}

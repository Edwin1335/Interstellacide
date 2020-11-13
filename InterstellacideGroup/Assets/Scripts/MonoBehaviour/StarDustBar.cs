using UnityEngine;
using UnityEngine.UI;

public class StarDustBar : MonoBehaviour
{
    /* Shared reference with Player  */
    public StarDustPoints starDustPoints;

    [HideInInspector]
    /* Player character */
    public Character character;

    public Image meterImage;

    // public Text hpText;

    float maxStarDustPoints;

    void Start()
    {
        maxStarDustPoints = character.maxStarDustPoints;
    }

    void Update()
    {
        /* Update healthbar based on players life value */
        if (character != null)
        {
            meterImage.fillAmount = starDustPoints.value / maxStarDustPoints;
            // hpText.text = "" + starDustPoints.value;
        }
    }
}

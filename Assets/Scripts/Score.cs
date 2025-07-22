using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform player;
    public TMP_Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (player.position.z + 43).ToString("0"); 
        // the "0" argument inside the ToString function allows us to convert float numbers to int
    }
}

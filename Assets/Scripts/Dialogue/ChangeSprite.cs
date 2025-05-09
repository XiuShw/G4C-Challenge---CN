using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour
{
  //Attach this script to an Image GameObject and set its Source Image to the Sprite you would like.
  SpriteRenderer image;
  public List<Sprite> Sprites;

  void Awake() {
    image = GetComponent<SpriteRenderer>();
  }
  public void ChangeTo(int index) {
    image.color = Color.white;
    image.sprite = Sprites[index];
  }
  public int GetCurrentSprite() {
    for (int i = 0; i < Sprites.Count; i++) {
      if (Sprites[i] == image.sprite) {
        return i;
      }
    }
    return -1;
  }
}

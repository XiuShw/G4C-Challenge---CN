using UnityEngine;

public class DialogueAssign : MonoBehaviour
{
    public Dialogue dialogueBeforeEnding;
    public Dialogue goodEnding;
    public Dialogue badEnding;
    public Dialogue badEnding2;
    public int threshold = 0;
    void Start()
    {
        Debug.Log("outcome is " + GameManager.outcomeValue);
        
        if (threshold == 0) {
            if (GameManager.outcomeValue >= 9){
                Debug.Log("too close to poor " + GameManager.outcomeValue);
                dialogueBeforeEnding.RootNode.nextDialogue = badEnding2;
            }
            else if (GameManager.outcomeValue <= 1){
                Debug.Log("too close to rich " + GameManager.outcomeValue);
                dialogueBeforeEnding.RootNode.nextDialogue = badEnding;
            }
            else {
                Debug.Log("middle outcome: " + GameManager.outcomeValue);
                dialogueBeforeEnding.RootNode.nextDialogue = goodEnding;
            }
        } 
        else {
            if (GameManager.peopleFed >= threshold) {
                dialogueBeforeEnding.RootNode.nextDialogue = goodEnding;
            } else {
                dialogueBeforeEnding.RootNode.nextDialogue = badEnding;
            }
        }
    }

}

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
        if (threshold == 0) {
            if (GameManager.outcomeValue >= 9){
                dialogueBeforeEnding.RootNode.nextDialogue = badEnding;
            }
            else if (GameManager.outcomeValue <= 1){
                dialogueBeforeEnding.RootNode.nextDialogue = badEnding2;
            }
            else {
                dialogueBeforeEnding.RootNode.nextDialogue = goodEnding;
            }
        }
        if (GameManager.peopleFed >= threshold) {
            dialogueBeforeEnding.RootNode.nextDialogue = goodEnding;
        }
        else {
            dialogueBeforeEnding.RootNode.nextDialogue = badEnding;
        }
    }
}

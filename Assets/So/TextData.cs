using UnityEngine;

[CreateAssetMenu(fileName = "TextData", menuName = "Custom/Text Data")]
public class TextData : ScriptableObject
{
    public string[] textArray;
    public int currentIndex;
}
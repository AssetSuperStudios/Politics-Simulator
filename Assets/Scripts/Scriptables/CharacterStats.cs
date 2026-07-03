using UnityEngine;

[CreateAssetMenu(fileName = "CharacterStats", menuName = "Scriptable Objects/CharacterStats")]
public class CharacterStats : ScriptableObject
{
    [SerializeField] public Sprite spriteImage;
    [SerializeField] public string stringName;
    [SerializeField] public string stringPath;
    [SerializeField] public float percentageMoneyModifier;
    [SerializeField] public float percentageMilitaryModifier;
    [SerializeField] public float percentageInfluenceModifier;
}

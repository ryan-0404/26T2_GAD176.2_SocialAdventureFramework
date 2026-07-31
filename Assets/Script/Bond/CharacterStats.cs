using UnityEngine;

namespace SAE.GAD176.Scripting2.Project2.CharacterBondSystem
{
    public class CharacterStats : MonoBehaviour
    {
        [SerializeField]
        protected string characterName = "-1";

        [SerializeField]
        protected int friendLevel = 0;

        [SerializeField]
        protected float bondExperience = 0.00f;
    }
    
}
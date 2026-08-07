using UnityEngine;
using UnityEngine.Events;

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

        // add events here for ChangeBondExperience()
        // BondLevelUP

        public UnityEvent changeBondExperienceEvent;

        private void Update()
        {
            if (Input.GetKeyUp(KeyCode.F))
            {
                changeBondExperienceEvent?.Invoke();
                ChangeBondExperience();
            }
            
        }

        //private void OnEnable()
        //{
        //    // invoke
        //    ChangeBondExperienceEvent.AddListener(ChangeBondExperience);
        //}

        //private void OnDisable()
        //{
        //    ChangeBondExperienceEvent.RemoveListener(ChangeBondExperience);
        //}

        public void ChangeBondExperience()
        {
            bondExperience += 15; // quest reward exp
            Debug.Log("Bond Increased " + bondExperience);
        }



    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Game.PlayerCharacter
{
    [CreateAssetMenu(fileName = "New State", menuName = "ability/Update Box Collider", order = 0)]
    public class UpdateBoxCollider : StateData
    {
        public Vector3 targetSize;
        public float sizeUpdateSpeed;
        public Vector3 targetCenter;
        public float centerUpdateSpeed;

        PlayerMovement playerMovement = null;


        public override void OnEnter(PlayerState c, Animator a, AnimatorStateInfo asi)
        {
            playerMovement = c.GetPlayerMoveMent(a);
            playerMovement.animationProgress.isUpdatingBoxCollider = true;
            playerMovement.animationProgress.targetSize = this.targetSize;
            playerMovement.animationProgress.sizeSpeed = this.sizeUpdateSpeed;
            playerMovement.animationProgress.targetCenter = this.targetCenter;
            playerMovement.animationProgress.centerSpeed = this.centerUpdateSpeed;
        }
        
        public override void OnAbilityUpdate(PlayerState c, Animator a, AnimatorStateInfo asi)
        {

        }

        public override void OnExit(PlayerState c, Animator a, AnimatorStateInfo asi)
        {
            playerMovement.animationProgress.isUpdatingBoxCollider = false;
        }

    }
}

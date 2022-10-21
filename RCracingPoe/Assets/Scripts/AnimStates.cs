using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Spectator.Animation
{

    public class AnimStates : StateMachineBehaviour
    {
        //[SerializeField] private Animator anim;
        private float StartAnim;
        private float endAnim;
        private float lastPosition = 2f;
        private float ChangeState = float.PositiveInfinity;
        private int HashPar;

        public override void OnStateEnter(Animator anim, AnimatorStateInfo stateInfo, int layerIndex)
        {
            HashPar = Animator.StringToHash("Position");
            base.OnStateEnter(anim, stateInfo, layerIndex); 
        }

        public override void OnStateUpdate(Animator anim, AnimatorStateInfo stateInfo, int Index)
        {
            
            lastPosition += Time.deltaTime;
            if (lastPosition >= ChangeState)
            {
                StartAnim = anim.GetFloat(HashPar);
                endAnim = Random.Range(0f, 1f);
                lastPosition = 0;
            }

             anim.SetFloat(HashPar, Mathf.Lerp(StartAnim, endAnim, lastPosition / ChangeState));

            base.OnStateUpdate(anim, stateInfo, Index);
        }
    }
}
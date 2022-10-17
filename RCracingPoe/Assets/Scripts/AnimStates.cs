using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Spectator.Animation
{


    public class AnimStates : StateMachineBehaviour
    {
        [SerializeField] private Animator anim;
        private float StartAnim;
        private float endAnim;
        private float lastPosition = 5f;
        private float ChangeState = float.PositiveInfinity;
        private int AnimPar;


        public override void OnStateEnter(Animator anim, AnimatorStateInfo stateInfo, int layerIndex)
        {
            AnimPar = Animator.StringToHash("Position");
            base.OnStateEnter(anim, stateInfo, layerIndex);
        }

        public override void OnStateUpdate(Animator anim, AnimatorStateInfo stateInfo, int Index)
        {

            base.OnStateUpdate(anim, stateInfo, Index);

            anim.SetFloat(AnimPar, Mathf.Lerp(StartAnim, endAnim, lastPosition / ChangeState));
            lastPosition += Time.deltaTime;
            if (lastPosition >= ChangeState)
            {
                StartAnim = anim.GetFloat(AnimPar);
                endAnim = Random.Range(0f, 1f);
                lastPosition = 0;
            }


        }
    }
}
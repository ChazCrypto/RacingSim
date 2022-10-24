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
        private float lastPosition = float.PositiveInfinity;
        private float ChangeStateFreq = 2f;
        private int HashPar;

        public override void OnStateEnter(Animator anim, AnimatorStateInfo stateInfo, int layerIndex)
        {
            HashPar = Animator.StringToHash("Pos");
            base.OnStateEnter(anim, stateInfo, layerIndex); 
        }

        public override void OnStateUpdate(Animator anim, AnimatorStateInfo stateInfo, int LayerIndex)
        {
            
            lastPosition += Time.deltaTime;
            if (lastPosition >= ChangeStateFreq)
            {
                StartAnim = anim.GetFloat(HashPar);
                endAnim = Random.Range(0f, 1f);
                lastPosition = 0;
            }

             anim.SetFloat(HashPar, Mathf.Lerp(StartAnim, endAnim, lastPosition / ChangeStateFreq));

            base.OnStateUpdate(anim, stateInfo, LayerIndex);
        }
    }
} 


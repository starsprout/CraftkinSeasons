using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAnimation : MonoBehaviour
{

    public AnimatorCustom customAnimator;

    Vector3 moveInput;

    MeshRenderer meshRenderer;

    void Start() => meshRenderer = GetComponent<MeshRenderer>();



    void Update()
    {
        moveInput = playerMovement.PlayerInput();

        if(moveInput.x > 0)
        {
            customAnimator.animations[0].playAnimation(customAnimator.framesPerSecond, meshRenderer);
        }

        if (moveInput.x < 0)
        {
            customAnimator.animations[1].playAnimation(customAnimator.framesPerSecond, meshRenderer);
        }

        if (moveInput.z > 0)
        {
            customAnimator.animations[2].playAnimation(customAnimator.framesPerSecond, meshRenderer);
        }

        if (moveInput.z < 0)
        {
            customAnimator.animations[3].playAnimation(customAnimator.framesPerSecond, meshRenderer);
        }
    }



}

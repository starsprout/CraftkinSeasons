using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Animation
{
    public string name;

    //stores textures in an array
    public Texture[] animationTextures;
    
 
    //switches the texture of the material in accordance with the fps
    public void playAnimation(int framesPerSecond, MeshRenderer meshRenderer)
    {
        float index = Time.time * framesPerSecond;

        index = (int)index % animationTextures.Length;

        meshRenderer.material.mainTexture = animationTextures[(int)index];
        
    }
}

[System.Serializable]
public class AnimatorCustom
{
    [Range(1, 30)]
    public int framesPerSecond;
    public Animation[] animations;
    
}




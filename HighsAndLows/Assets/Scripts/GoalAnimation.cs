using UnityEngine;

public class Example : MonoBehaviour
{
    //Fetch the Animator
    Animator m_Animator;
    // Use this for deciding if the GameObject can jump or not
    bool m_EndLevelAnimation;

    void Start()
    {
        //This gets the Animator, which should be attached to the GameObject you are intending to animate.
        m_Animator = gameObject.GetComponent<Animator>();
        // The GameObject cannot jump
        m_EndLevelAnimation = false;
    }

    void Update()
    {
        //Click the mouse or tap the screen to change the animation
        if (Input.GetMouseButtonDown(0))
            m_EndLevelAnimation = true;

        //Otherwise the GameObject cannot jump.
        else m_EndLevelAnimation = false;

        //If the GameObject is not jumping, send that the Boolean “Jump” is false to the Animator. The jump animation does not play.
        if (m_EndLevelAnimation == false)
            m_Animator.SetBool("EndLevelAnimation", false);

        //The GameObject is jumping, so send the Boolean as enabled to the Animator. The jump animation plays.
        if (m_EndLevelAnimation == true)
            m_Animator.SetBool("EndLevelAnimation", true);
    }
}
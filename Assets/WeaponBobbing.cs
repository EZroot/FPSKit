using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CMF;

public class WeaponBobbing : MonoBehaviour
{
    public float bobbingAmount = 0.05f;
    public AdvancedWalkerController characterMover;
    float defaultPosY = 0;
    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        defaultPosY = transform.localPosition.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (!characterMover.IsGrounded())
        {
            timer = 0;
            transform.localPosition = new Vector3(transform.localPosition.x, Mathf.Lerp(transform.localPosition.y, defaultPosY, Time.deltaTime * characterMover.MovementSpeed + 6f), transform.localPosition.z);
            return;
        }

        if (Mathf.Abs(characterMover.GetMovementVelocity().x) > 0.1f || Mathf.Abs(characterMover.GetMovementVelocity().z) > 0.1f)
        {
            //Player is moving
            timer += Time.deltaTime * characterMover.MovementSpeed;
            transform.localPosition = new Vector3(transform.localPosition.x, defaultPosY + Mathf.Sin(timer) * bobbingAmount, transform.localPosition.z);
        }
        else
        {
            //Idle
            timer = 0;
            transform.localPosition = new Vector3(transform.localPosition.x, Mathf.Lerp(transform.localPosition.y, defaultPosY, Time.deltaTime * characterMover.MovementSpeed), transform.localPosition.z);
        }
    }
}
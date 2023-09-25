using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotorScript : MonoBehaviour
{
    public HingeJoint2D armDown;
    public HingeJoint2D armUp;
    public HingeJoint2D hand;

    private JointMotor2D armDownMotorRef;
    private JointMotor2D armUpMotorRef;
    private JointMotor2D handMotorRef;

    public float speed = 40f;
    // Start is called before the first frame update
    void Start()
    {
        armDownMotorRef = armDown.motor;
        armUpMotorRef = armUp.motor;
        handMotorRef = hand.motor;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            armDown.useMotor = true;
            armDownMotorRef.motorSpeed = - speed;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            armUp.useMotor = true;
            armUpMotorRef.motorSpeed = -speed;
        }
        else if (Input.GetKey(KeyCode.E))
        {
            armDown.useMotor = true;
            armDownMotorRef.motorSpeed = speed;
        }
        else if (Input.GetKey(KeyCode.R))
        {
            armUp.useMotor = true;
            armUpMotorRef.motorSpeed = speed;
        }
        else if (Input.GetKey(KeyCode.O))
        {
            hand.useMotor = true;
            handMotorRef.motorSpeed = -speed;
        }
        else if (Input.GetKey(KeyCode.P))
        {
            hand.useMotor = true;
            handMotorRef.motorSpeed = speed;
        }
        else
        {
            armDown.useMotor = false;
            armUp.useMotor = false;
            hand.useMotor = false;
        }
    }
}

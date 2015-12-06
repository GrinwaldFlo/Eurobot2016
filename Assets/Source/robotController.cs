using UnityEngine;
using System.Collections;
using Assets.Source;

public class robotController : MonoBehaviour
{
	public float acceleration = 1f;
	public float ratioRotation = 0.4f;
	public enPlayer player;

	public float[] speed = new float[] { 1000, 350 };
	public float[] speedAngular = new float[] { 1000, 350 };
	int curSpeed = 0;

	public float speedMe;

	Rigidbody r;

	// Use this for initialization
	void Start()
	{
		r = this.GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update()
	{

	}

	public void FixedUpdate()
	{
		Move();
  }

	void Move()
	{
		float h, v;

		if (Input.GetKey(gVar.keyUp[(int)player]))
			v = 1f;
		else if (Input.GetKey(gVar.keyDown[(int)player]))
			v = -1f;
		else
			v = 0f;
		if (Input.GetKey(gVar.keyLeft[(int)player]))
			h = -1f;
		else if (Input.GetKey(gVar.keyRight[(int)player]))
			h = 1f;
		else
			h = 0f;

		Vector3 worldForcePosition = transform.TransformPoint(0f, 0f, 0f);
		Vector3 wordForce = transform.TransformPoint(new Vector3(acceleration * v, 0f, 0f));

		if(r.velocity.magnitude < speed[0])
			r.AddForceAtPosition(wordForce, worldForcePosition);

		if(r.angularVelocity.magnitude < speedAngular[0])
			r.AddRelativeTorque(0f, acceleration * h * ratioRotation, 0f, ForceMode.Force);
	}
}

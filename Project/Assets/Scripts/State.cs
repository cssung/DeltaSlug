using UnityEngine;
using System.Collections;

//Done debugging, so make this into an interface or abstract base.
public class State  {
    public State () {
    }

    public virtual void Update(Enemy e) {
		Debug.Log("Please derive from State and override update.");
	}

    public virtual void Enter(Enemy e) {
		Debug.Log("Please derive from State and override Enter.");
	}

    public virtual void Exit(Enemy e)  {
		Debug.Log("Please derive from State and override exit.");
	}
}

public class SeekState : State {
	public SeekState() {
	}
			
	public override void Update(Enemy e) {
		Transform currentPos = e.GetComponent<Transform>();
		Vector2 target = e.VectorToPlayer();
		Vector2 start = new Vector2(currentPos.position.x, currentPos.position.y);
		Vector2 dirrection = target - start;
		float xDistance = dirrection.x;
		xDistance = Mathf.Abs (xDistance);

		if(xDistance < e.seekThreshold) {
			e.ChangeState(new AttackState());
		} 
		else {
			if(dirrection.x < 0)
				e.Move(-e.force );
			else
				e.Move(e.force);
		}
	}
	
	public override void Enter(Enemy e) {
		e.getAnimmator().SetBool ("Moving", true);
	}
	
	public override void Exit(Enemy e)  {
	}
}

public class AttackState : State {
	public AttackState() {
	}
	
	public override void Update(Enemy e) {
		Transform currentPos = e.GetComponent<Transform>();
		Vector2 target = e.VectorToPlayer();
		Vector2 start = new Vector2(currentPos.position.x, currentPos.position.y);
		Vector2 dirrection = target - start;
		float xDistance = dirrection.x;
		xDistance = Mathf.Abs(xDistance);

		if (dirrection.x < 0)
			e.FaceLeft();
		else
			e.FaceRight();

		if(xDistance >= e.seekThreshold) {
			e.ResetAttackCooldown();
			e.ChangeState(new SeekState ());
		} 
		else {
			if(e.attackCooldown <= 0) {
				e.Attack(dirrection);
			}
			else if(e.attackCooldown > 0) {
				e.attackCooldown -= Time.deltaTime;
			}
		}

		//used to stop the player from sending the enemy flying from being touched
		Vector2 dv = e.rb.velocity;
		dv.x = 0;
		e.rb.velocity = dv;
	}
	
	public override void Enter(Enemy e) {
		e.getAnimmator().SetBool ("Moving", false);

	}
	
	public override void Exit(Enemy e)  {
	}
}
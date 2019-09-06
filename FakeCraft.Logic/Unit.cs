using System;

namespace FakeCraft
{
    public abstract class Unit
    {
        public int HP { get; set; }

        public abstract string ToText();

        public virtual void TakeDamage(int damage)
        {
            while (damage > 0)
            {
                if (HP == 0)
                {
                    OnDead(damage);

                    break;
                }

                damage--;
                HP--;
            }
        }

        public void TakeMultipleDamages(params int[] damages)
        {
            for (int i = 0; i < damages.Length; i++)
                TakeDamage(damages[i]);
        }

        #region Dead event things for C# 3.0
public event EventHandler<DeadEventArgs> Dead;

protected virtual void OnDead(DeadEventArgs e)
{
	if (Dead != null)
		Dead(this, e);
}

private DeadEventArgs OnDead(int remainingDamage )
{
	DeadEventArgs args = new DeadEventArgs(remainingDamage );
    OnDead(args);

    return args;
}

private DeadEventArgs OnDeadForOut()
{
	DeadEventArgs args = new DeadEventArgs();
    OnDead(args);

    return args;
}

public class DeadEventArgs : EventArgs
{
	public int RemainingDamage { get; set;} 

	public DeadEventArgs()
    {
	}
	
	public DeadEventArgs(int remainingDamage )
    {
		RemainingDamage = remainingDamage; 
	}
}
#endregion
    }
}

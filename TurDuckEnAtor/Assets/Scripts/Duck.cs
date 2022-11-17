using System;
public class Duck : Bird
{
    /// <summary>
    /// Do not call this method.  The default constructor throws an exception because
    /// the duck needs a weight.
    /// </summary>
    /// <exception cref="NotSupportedException"></exception>
	public Duck()
    {
        throw new NotSupportedException();
    }

    public Duck(int WeightInOunces) : base()
	{
        base.WeightInOunces = WeightInOunces;
    }

    public override void RemoveBonesAndAdjustWeight()
    {
        if (this.HasBones)
        {
            this.WeightInOunces -= (int)((float)this.WeightInOunces * .28);
            this.HasBones = false;
        }
    }

    public override int GetCalories()
    {
        return this.WeightInOunces * 96;
    }
}


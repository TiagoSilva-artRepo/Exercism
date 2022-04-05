using System;

abstract class Character
{
    private string characterType;
    private bool isVulnerable;
    protected Character(string characterType)
    {
        this.characterType = characterType;
        this.isVulnerable = false;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        return isVulnerable;
    }

    public override string ToString()
    {
        return $"Character is a {this.characterType}";
    }
}

class Warrior : Character
{
    private const int maxDamage = 10;
    private const int minDamage = 6;

    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        return target.Vulnerable() ? 10 : 6;
    }
}

class Wizard : Character
{
    private const int maxDamage = 12;
    private const int minDamage = 3;
    private bool speelPrepared;
    public Wizard() : base("Wizard")
    {
        this.speelPrepared = false;
    }

    public override int DamagePoints(Character target)
    {
        return this.speelPrepared ? maxDamage : minDamage;
    }

    public void PrepareSpell()
    {
        this.speelPrepared = true;
    }

    public override bool Vulnerable()
    {
        return !this.speelPrepared;
    }
}

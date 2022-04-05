using System;
using System.Collections.Generic;

public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }
    // TODO: implement equality and GetHashCode() methods
    public override bool Equals(object obj)
    {
        FacialFeatures facialFeatures = (FacialFeatures) obj;
        return ((obj == null) || ! this.GetType().Equals(obj.GetType())) ? false :
            (this.EyeColor == facialFeatures.EyeColor && this.PhiltrumWidth == facialFeatures.PhiltrumWidth);
    }

    public override int GetHashCode()
    {
        return this.EyeColor.GetHashCode() * this.PhiltrumWidth.GetHashCode();
    }
}

public class Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }
    // TODO: implement equality and GetHashCode() methods
    public override bool Equals(object obj)
    {
        Identity identity = (Identity) obj;
        return ((obj == null) || ! this.GetType().Equals(obj.GetType())) ? false :
            (this.Email == identity.Email && this.FacialFeatures.Equals(identity.FacialFeatures));
    }

    public override int GetHashCode()
    {
        return this.Email.GetHashCode() + this.FacialFeatures.GetHashCode();
    }
}

public class Authenticator
{
    private readonly HashSet<Identity> Identities = new HashSet<Identity>();

    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB) => faceA.Equals(faceB);

    public bool IsAdmin(Identity identity) => identity.Email == "admin@exerc.ism" && identity.FacialFeatures.Equals(new FacialFeatures("green", 0.9m));

    public bool Register(Identity identity) => Identities.Add(identity);

    public bool IsRegistered(Identity identity) => Identities.Contains(identity);

    public static bool AreSameObject(Identity identityA, Identity identityB) => identityA == identityB;
}

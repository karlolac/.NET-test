public class Specification
{
    public double UnlockedRatio { get; set; }
    public double LockedRatio { get; set; }
    public double BlockedRatio { get; set; }

    public Specification(double totalUnlocked, double totalLocked, double totalBlocked)
    {
        UnlockedRatio = totalUnlocked;
        LockedRatio = totalLocked;
        BlockedRatio = totalBlocked;
    }

}


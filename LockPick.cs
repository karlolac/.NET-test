class LockPick
{
    const int LENGHT = 4;
    private HashSet<string> attempts;
    private Random generator;

    public LockPick(Random generator)
    {
        this.generator = generator;
        attempts = new HashSet<string>();
    }

    public void Pick(Door door)
    {
        while (door.Status == Status.Locked)
        {
            string pin = GeneratePin();
            attempts.Add(pin);
            door.UnlockDoor(pin);
        }
    }
    private string GeneratePin()
    {
        string candidate = "";
        for (int i = 0; i < LENGHT; i++) { candidate += generator.Next(10); }
        return candidate;
    }


}


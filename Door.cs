class Door
{
    string pin;
    string puk;
    int attemptsRemaining;
    Status status;


    public Door(string pin, string puk)
    {
        this.pin = pin;
        this.puk = puk;
        status = Status.Locked;
        attemptsRemaining = 5;
    }
    public Status Status { get; }

    public override string ToString()
    {
        return $"Remaining attempts: {attemptsRemaining}, status: {status}";
    }

    public void UnlockDoor(string entryPin)
    {
        if (Status != Status.Blocked)
        {
            if (pin == entryPin)
            {
                status = Status.Unlocked;
            }
            else
            {
                attemptsRemaining--;
                if (attemptsRemaining == 0)
                {
                    status = Status.Blocked;
                }
            }
        }
        else
        {
            return;
        }
    }

    public void UnblockDoor(int attemptsRemainingForPuk, string entryPuk)
    {
        attemptsRemaining = attemptsRemainingForPuk;
        if (status == Status.Blocked)
        {
            if (puk == entryPuk)
            {
                status = Status.Unlocked;
            }
            else
            {
                attemptsRemaining--;
                if (attemptsRemaining == 0)
                {
                    status = Status.Blocked;
                }
            }
        }
    }


}

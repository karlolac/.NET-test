class Labirint
{
    Dictionary<string, Door> doors;

    public Labirint()
    {
        doors = new Dictionary<string, Door>();
    }
    public void AddDoor(string name, Door door)
    {
        doors.Add(name, door);
    }


    public Specification GetSpecification()
    {
        //Specification result = new Specification(0,0,0);
        int totalDoors = 0;
        int unlocked = 0;
        int locked = 0;
        int blocked = 0;

        foreach (var item in doors.Values)
        {
            if (item.Status == Status.Locked)
            {
                locked++;
            }
            else if (item.Status == Status.Unlocked)
            {
                unlocked++;
            }
            else
            {
                blocked++;
            }
        }

        int numberOfDoors = doors.Count;
        return new Specification(unlocked / numberOfDoors, blocked / numberOfDoors, locked / numberOfDoors);



    }


}


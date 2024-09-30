using System.Collections.Generic;

public class Player { }

public class Gun { }

public class TargetFollower { } 

public class Unit { }

class UnitBase
{
    public IReadOnlyCollection<Unit> Units { get; private set; }
}
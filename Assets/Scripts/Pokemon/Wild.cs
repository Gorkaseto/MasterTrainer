using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public abstract class Wild : Pokemon
{
    public abstract List<int> catchSuccess { get; }
    public abstract List<int> extendedCatch { get; set; }

    public bool Catch(int diceRoll)
    {
        if (extendedCatch.IndexOf(diceRoll) != -1)
            return true;
        return false;
    }

    public void ExtendCatch(int[] catchExtension)
    {
        extendedCatch.AddRange(catchExtension);
    }

    public void ResetExtension()
    {
        extendedCatch = catchSuccess;
    }
}

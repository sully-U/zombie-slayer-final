using System;
using zombie_slayer_final.Casting;
using System.Collections.Generic;

namespace zombie_slayer_final
{
        /// <summary>
    /// The base class of all other actions.
    /// </summary>
    public abstract class Action
    {
        public virtual void Execute(Dictionary<string, List<Actor>> cast)
        {
            throw new NotImplementedException();
        }
    }
}
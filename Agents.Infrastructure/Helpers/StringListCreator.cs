using System;
using System.Collections.Generic;
using System.Linq;

namespace Agents.Infrastructure.Helpers
{
    public class StringListCreator : IStringListCreator
    {
        public List<string> PrepareList(string wordsSeparatedWithCommas)
        {
            return new List<string>(wordsSeparatedWithCommas.Split(','));
        }
    }
}
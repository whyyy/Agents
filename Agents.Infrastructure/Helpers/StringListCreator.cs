using System;
using System.Collections.Generic;
using System.Linq;
using Agents.Infrastructure.Extensions;

namespace Agents.Infrastructure.Helpers
{
    public class StringListCreator : IStringListCreator
    {
        public List<string> PrepareList(string wordsSeparatedWithCommas)
        {
            var words = wordsSeparatedWithCommas.Split(',').Select(w => w.RemoveFormatting()).ToList();
            return words;
        }
    }
}
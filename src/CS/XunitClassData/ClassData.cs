using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace $rootnamespace$
{
    public class $safeitemrootname$ : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new object() };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
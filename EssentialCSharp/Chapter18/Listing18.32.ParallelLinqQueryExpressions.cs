﻿namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_32
{
    using System.Collections.Generic;
    using System.Linq;

    class Cryptographer
    {
        // ...
        public List<string>
          Encrypt(IEnumerable<string> data)
        {

            ParallelQuery<IGrouping<char, string>> parallelGroups;
            parallelGroups =
                from text in data.AsParallel()
                orderby text
                group text by text[0];


            // Show the total count of items still
            // matches the original count
            System.Diagnostics.Trace.Assert(
                data.Count() == parallelGroups.Sum(
                    item => item.Count()));
            // ...


            return data.AsParallel().Select(
                item => Encrypt(item)).ToList();
        }

        // ...

        private string Encrypt(string item)
        {
            // ...
            throw new System.NotImplementedException();
        }

    }
}



using System;
using System.Collections.Generic;
using System.Text;

namespace DrillWpfObject
{
    class Result
    {
        private int distance_in_m;
        private string runner;
        private double time_in_s;

        public Result(int d, string r, double t)
        {
            distance_in_m = d;
            runner = r;
            time_in_s = t;
        }

        public override string ToString()
        {
            return Environment.NewLine + distance_in_m + "m" + Environment.NewLine + time_in_s + "s" + Environment.NewLine + runner + Environment.NewLine;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grades
{
    public class GradeStats
    {
        public GradeStats()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }
        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;
    }
}

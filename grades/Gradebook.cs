﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grades
{
    class Gradebook
    {

        public Gradebook()
        {
            grades = new List<float>();
        }
        
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        List<float> grades; //hoisted above constructor (Gradebook)
    }
}

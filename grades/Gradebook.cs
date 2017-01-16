using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grades
{
    public class Gradebook
    {

        public Gradebook()
        {
            grades = new List<float>();
        }
        
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }
        //grades access modifier is set to private as default
        private List<float> grades; //hoisted above constructor (Gradebook)

        public GradeStats ComputeStats()
        {
            GradeStats stats = new GradeStats();

            float sum = 0;
            foreach (float grade in grades)
            {
                sum += grade;
                //if (grade > stats.HighestGrade) //this is one way to do it
                //{
                //    stats.HighestGrade = grade;
                //}
                //if (grade < stats.LowestGrade)
                //{
                //    stats.LowestGrade = grade;
                //}

                //this is a more concise way using Math class on .NET framework
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
            }
            
            stats.AverageGrade = sum / grades.Count;
            
            return stats;
        }

        public string Name;
    }
}

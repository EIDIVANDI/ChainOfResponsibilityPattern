using ChaintOfResponsibilityCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ChainTeacherHandler teacher = new ChainTeacherHandler();
            ChainStudentHandler student = new ChainStudentHandler();
            ChainAnimatorHandler animator = new ChainAnimatorHandler();

            teacher.ConfigurHandler(student);
            animator.ConfigurHandler(teacher);

            Console.WriteLine(teacher.DoResponsibility(true));
            Console.WriteLine(animator.DoResponsibility(true));
        }
    }
}

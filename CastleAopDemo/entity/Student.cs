using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleAopDemo.entity
{
   public class Student
    {
        public virtual void Show()
        {
            Console.WriteLine("我是学生");
        }
    }
}

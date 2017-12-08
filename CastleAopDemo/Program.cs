using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;
using CastleAopDemo.entity;
using CastleAopDemo.Interceptor;
using Common.Log;
namespace CastleAopDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var proxy=new ProxyGenerator();
            var log = new LogInterceptor();
            var student = proxy.CreateClassProxy<Student>(log);
            student.Show();
            Console.Read();
        }
    }
}

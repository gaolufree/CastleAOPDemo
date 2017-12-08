using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;
using Common.Log;

namespace CastleAopDemo.Interceptor
{
    public class LogInterceptor : StandardInterceptor
    {
         private  Log4NetProvider log { get; set; }
        /// <summary>
        /// 执行方法前
        /// </summary>
        /// <param name="invocation"></param>
        protected override void PreProceed(IInvocation invocation)
        {
            log=new Log4NetProvider("OrderLog");
            log.Info("+--------------------开始执行--------------------------+");
        }
        /// <summary>
        /// 执行方法
        /// </summary>
        /// <param name="invocation"></param>
        protected override void PerformProceed(IInvocation invocation)
        {
            log.Info($"| 执行方法{invocation.TargetType.FullName}.{invocation.Method.Name} |");
            invocation.Proceed();
           
        }
        /// <summary>
        /// 执行方法后
        /// </summary>
        /// <param name="invocation"></param>
        protected override void PostProceed(IInvocation invocation)
        {
            log.Info("+--------------------执行完毕--------------------------+");
        }
    }
}

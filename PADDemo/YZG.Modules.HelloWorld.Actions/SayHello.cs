using Microsoft.Flow.RPA.Desktop.Modules.SDK;
using Microsoft.Flow.RPA.Desktop.Modules.SDK.Attributes;
using Microsoft.Flow.RPA.Desktop.Modules.SDK.Extended.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YZG.Modules.HelloWorld.Actions
{
    [Action(Id = "SayHello")]
    [Icon(Code = "EFF7")]
    [Throws("MyError")]
    public class SayHello : ActionBase
    {
        [InputArgument]
        public string UserName { get; set; }    

        [OutputArgument]
        public string Result { get; set; }
        public override void Execute(ActionContext context)
        {
            try
            {
                this.Result = $"{UserName} 你好，中国欢迎你！ -{DateTime.Now}";
            }
            catch (ActionException ex)
            {
                throw new ActionException("MyError", ex.Message, ex.InnerException);
            }
        }
    }
}

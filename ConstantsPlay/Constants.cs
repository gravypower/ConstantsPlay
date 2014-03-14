using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Threading;

namespace ConstantsPlay
{
    public class Constants : IConstants
    {
        private ComponentResourceManager resources;

        public Constants()
        {
            resources = new ComponentResourceManager(typeof(Resource1));
            
        }

        public virtual string InvalidTemplateObject
        {
            get { return "Request operation cannot continue due to an invalid Template object."; }
        }

        public string NoTemplateTitle
        {
            get { return resources.GetString("NoTemplateTitle", Thread.CurrentThread.CurrentCulture); }
        }
    }
}

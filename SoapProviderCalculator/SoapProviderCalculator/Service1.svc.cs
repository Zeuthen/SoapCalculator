using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SoapProviderCalculator
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if(composite == null)
            {
                throw new ArgumentNullException(nameof(composite));
            }
            if(composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }


        public double Addition(double a, double b)
        {
            return a + b;
        }
        public double Substract(double a, double b)
        {
            return a - b;
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Division(double a, double b)
        {
            return a / b;
        }
        public double Arithmetic(double a, double b, out double addition, out double substraction, out double multiply, out double division)
        {
            addition = a + b;
            substraction = a - b;
            multiply = a * b;
            division = a / b;
            return addition + substraction + multiply + division;
        }
    }
}

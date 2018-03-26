using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathamaticsDLL
{
    public class Class1
    {
        //Calculation that Caculates and checks for null.
        public double Caluculation(double Number1, double number2, int calculation)
        {
            try
            {
                double Output = 0;
                if (calculation == 1)
                {
                    Output = Number1 + number2;
                }
                else if (calculation == 2)
                {
                    Output = Number1 - number2;
                }
                else if (calculation == 3)
                {
                    Output = Number1 * number2;
                }
                else if (calculation == 4)
                {
                    Output = Number1 / number2;
                }

                if (Output > 0)
                {
                    return Output;
                }
                else
                {
                    Output = 0;
                }
                return Output;
            }
            catch(Exception e)
            {
                throw e;
            }
            
        }

        public double Sin(double Sinn)
        {
            try
            {
                Sinn = Math.Sin(Sinn);
                
            }
            catch (Exception e)
            {
                throw e;

            }
            return Sinn; 
        }

        public double Tan(double Tan)
        {
            try
            {
                Tan = Math.Tan(Tan);
            }
            catch(Exception e)
            {
                throw e;
            }
            return Tan;
        }

        public double Cosine(double Cos)
        {
            try
            {
                Cos = Math.Cos(Cos);
            }
            catch(Exception e)
            {
                throw e;
            }
            return Cos;
        }
        
        public double SqaureRoot(double SqaureRoot)
        {
            try
            {
                SqaureRoot = Math.Sqrt(SqaureRoot);
            }
            catch(Exception e)
            {
                throw e;
            }
            return SqaureRoot;
        }
        public double CubeRoot(double CubeRoot)
        {
            try
            {
                CubeRoot = Math.Pow(CubeRoot,3);
            }
            catch(Exception e)
            {
                throw e;
            }
            return CubeRoot;
        }
        public double Inverse(double a)
        {
            double Inversee;
            try
            {
                Inversee = -a;
            }
            catch(Exception e)
            {
                throw e;
            }
            return Inversee;
        }
    }
}

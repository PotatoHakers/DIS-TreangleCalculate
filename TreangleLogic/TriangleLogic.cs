using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace TriangleLogic
{
    public class Triangle
    {
        private double sideA;
        private double sideB;
        private double sideC;

        JsonWriter writer;

        public Triangle(double a, double b, double c)
        {
            StreamWriter logFile = File.CreateText("calculatorlog.json");
            logFile.AutoFlush = true;
            writer = new JsonTextWriter(logFile);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartObject();
            writer.WritePropertyName("Operations");
            writer.WriteStartArray();

            if (a > 0 && b > 0 && c > 0)
            {
                sideA = a;
                sideB = b;
                sideC = c;
            }
            
        }
        public double CalculateArea()
        {
            
            
            
            double s = (sideA + sideB + sideC) / 2;
            double result = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
            writer.WriteStartObject();
            writer.WritePropertyName("Ввод стороны А");
            writer.WriteValue(sideA);
            writer.WritePropertyName("Ввод стороны B");
            writer.WriteValue(sideB);
            writer.WritePropertyName("Ввод стороны C");
            writer.WriteValue(sideC);
            writer.WritePropertyName("Result");
            writer.WriteValue(result);
            writer.WriteEndObject();

            return result;
        }

        public void Finish()
        {
            writer.WriteEndArray();
            writer.WriteEndObject();
            writer.Close();
        }


    }
}
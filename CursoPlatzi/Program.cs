using System;

namespace CursoPlatzi
{
    class Program
    {
        static void Main(string[] args)
        {

            int _tipoInt = 1;
            string _tipoStr = "Jhon";
            bool _tipoBool = true;
            float _tipoFloat = 5.3F;
            long _tipoLong = 9223372036854775807;
            double _tipoDouble = 2.5;
            decimal _tipoDecimal = 3.40m;
            uint _tipoGuid = 321;
            var chars = new[]{
                'j',
                '\u006A',
                '\x006A',
                (char)106,

                };

            Console.WriteLine("Welcome course c# basic. Introduction");

            TipoDeDatos<int> tipoInt = new TipoDeDatos<int>(_tipoInt);
            TipoDeDatos<string> tipoStr = new TipoDeDatos<string>(_tipoStr);
            TipoDeDatos<bool> tipoBool = new TipoDeDatos<bool>(_tipoBool);
            TipoDeDatos<float> tipoFloat = new TipoDeDatos<float>(_tipoFloat);
            TipoDeDatos<double> tipoDouble = new TipoDeDatos<double>(_tipoDouble);
            TipoDeDatos<decimal> tipoDecimal = new TipoDeDatos<decimal>(_tipoDecimal);
            TipoDeDatos<uint> tipoUint = new TipoDeDatos<uint>(_tipoGuid);
            TipoDeDatos<char[]> tipoChar = new TipoDeDatos<char[]>(chars);
            TipoDeDatos<long> tipoLong = new TipoDeDatos<long>(_tipoLong);

            Console.WriteLine(tipoInt._tipo);
            Console.WriteLine(tipoStr._tipo);
            Console.WriteLine(tipoBool._tipo);
            Console.WriteLine(tipoFloat._tipo);
            Console.WriteLine(tipoDouble._tipo);
            Console.WriteLine(tipoDecimal._tipo);
            Console.WriteLine(tipoUint._tipo);
            Console.WriteLine(tipoChar._tipo);
            Console.WriteLine(tipoLong._tipo);
        }

    }

}
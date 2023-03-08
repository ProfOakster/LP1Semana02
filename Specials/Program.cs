using System;

namespace Specials
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte sb_max = sbyte.MaxValue, sb_min = sbyte.MinValue;
            byte b_max = byte.MaxValue, b_min = byte.MinValue;
            short sh_max = short.MaxValue, sh_min = short.MinValue;
            ushort us_max = ushort.MaxValue, us_min = ushort.MinValue;
            int in_max = int.MaxValue, in_min = int.MinValue;
            uint ui_max = uint.MaxValue, ui_min = uint.MinValue;
            long lg_max = long.MaxValue, lg_min = long.MinValue;
            ulong ul_max = ulong.MaxValue, ul_min = ulong.MinValue;
            float ft_max = float.MaxValue, ft_min = float.MinValue;
            double db_max = double.MaxValue, db_min = double.MinValue;
            decimal dc_max = decimal.MaxValue, dc_min = decimal.MinValue;
            char ch_max = char.MaxValue, ch_min = char.MinValue;

            float ft_posinf = float.PositiveInfinity,
            ft_neginf = float.NegativeInfinity,
            ft_nan = float.NaN;

            double db_posinf = double.PositiveInfinity,
            db_neginf = double.NegativeInfinity,
            db_nan = double.NaN;

            Console.WriteLine($"sbyte: max value={sb_max} ; min value={sb_min}");
            Console.WriteLine($"byte: max value={b_max} ; min value={b_min}");
            Console.WriteLine($"short: max value={sh_max} ; min value={sh_min}");
            Console.WriteLine($"ushort: max value={us_max} ; min value={us_min}");
            Console.WriteLine($"int: max value={in_max} ; min value={in_min}");
            Console.WriteLine($"uint: max value={ui_max} ; min value={ui_min}");
            Console.WriteLine($"long: max value={lg_max} ; min value={lg_min}");
            Console.WriteLine($"ulong: max value={ul_max} ; min value={ul_min}");
            Console.WriteLine($"float: max value={ft_max} ; min value={ft_min}");
            Console.WriteLine($"double: max value={db_max} ; min value={db_min}");
            Console.WriteLine($"decimal: max value={dc_max} ; min value={dc_min}");
            Console.WriteLine($"char: max value={ch_max} ; min value={ch_min}");

            Console.WriteLine(
                $"float specials: +Inf={ft_posinf}; -Inf={ft_neginf}; NaN={ft_nan}"
                );

                Console.WriteLine(
                $"double specials: +Inf={db_posinf}; -Inf={db_neginf}; NaN={db_nan}"
                );
        }
    }
}

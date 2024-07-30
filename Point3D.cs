using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitAssignment
{
    internal class Point3D : IFormattable
    { 
            public float X { get; private set; }
            public float Y { get; private set; }
            public float Z { get; private set; }

            public Point3D(float x, float y, float z)
            {
                X = x;
                Y = y;
                Z = z;
            }

            public override string ToString()
            {
                return $"Point3D: X={X}, Y={Y}, Z={Z}";
            }

            public string ToString(string format, IFormatProvider formatProvider)
            {
                if (format == null)
                    return ToString(); // Default format

                switch (format.ToUpper())
                {
                    case "X":
                        return $"X={X}";
                    case "Y":
                        return $"Y={Y}";
                    case "Z":
                        return $"Z={Z}";
                    case "G":
                    case "F":
                        return ToString(); // Default or general format
                    default:
                        throw new FormatException($"Unsupported format '{format}'");
                }
            }
        }
    }


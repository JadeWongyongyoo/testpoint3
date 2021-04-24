using System;

namespace สอบปฎิบัติครั้งที่1
{
    class Program
    {
        static void Main(string[] args)
        {
            float mode = float.Parse(Console.ReadLine());
            float filmBackWidth = float.Parse(Console.ReadLine());
            float fLength, fov;

            if (filmBackWidth > 0)
            {

                if (mode == fLength)
                {
                    float.Parse(Console.ReadLine());
                    if (fLength > 0)
                    {
                        fov = 2 * Math.Atan(filmBackWidth / (2 * fLength));
                        Console.WriteLine("fLength = {0}", fLength);
                    }
                    else
                    {
                        while (fLength < 0)
                        {
                            Console.WriteLine("Invalid fLegnth Pls input again.");
                            float.Parse(Console.ReadLine());
                        }

                    }
                }
                if (mode == fov)
                {
                    {
                        float.Parse(Console.ReadLine());
                        if (fov > 0.1 && fov < 6.28)
                        {
                            fLength = filmBackWidth / (2 * Math.Atan(fov / 2));
                            Console.WriteLine("fLength = {0}", fov);
                        }
                        else
                        {
                            while (fLength < 0)
                            {
                                Console.WriteLine("Invalid fLegnth Pls input again.");
                                float.Parse(Console.ReadLine());
                            }

                        }

                    }
                }
                else
                {
                    while (filmBackWidth != 0)
                    {
                        Console.WriteLine("Invalid filmBackWidth. Please in put again.");
                        mode = float.Parse(Console.ReadLine());
                    }
                }

            }
        }
    }
}

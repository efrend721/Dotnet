using System;
using System.IO;
namespace OsAnalityc
{

    internal class Program
    {
        private static void Main(string[] args)
        
        {
            GetMemoryInfo();
        }
        private static void GetMemoryInfo()
        {
            long memTotal = 0;
            long memAvailable = 0;
            
            
            var lines = File.ReadAllLines("/proc/meminfo");
            foreach (var line in lines)
            {
                if (line.StartsWith("MemTotal", StringComparison.OrdinalIgnoreCase))
                {
                    memTotal = long.Parse(line.Split(':')[1].Replace("kB", "").Trim());
                    Console.WriteLine($"MemTotal: {memTotal}");
                }
                if (line.StartsWith("MemAvailable", StringComparison.OrdinalIgnoreCase))
                {
                    memAvailable = long.Parse(line.Split(':')[1].Replace("kB", "").Trim());
                    Console.WriteLine($"MemAvailable: {memAvailable}");
                }
                if (memTotal > 0 && memAvailable > 0)
                {
                    long memUsedKb = memTotal - memAvailable;
                    long memUsedMb = memUsedKb / 1024; 
                    int porcentaje = (int)(memUsedKb * 100.0 / memTotal);
                    Console.WriteLine($"Memory Used in MB: {memUsedMb} \t {porcentaje} % ");
                    Console.WriteLine("Ervis Morales");
                    
                    int result = 3 + 1 * 5 / 2;
                    
                    Console.WriteLine(result);

                    break;
                }
                
            }
        }
    }
}

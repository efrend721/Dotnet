using System;
using System.Collections.Generic;
using static System.IO.Path;
using static System.Environment;
using System.Xml.Serialization;


namespace serializingAsXML
{
    // Include derived classes in XML serialization
    [XmlInclude(typeof(Circle))]
    [XmlInclude(typeof(Rectangle))]
    public abstract class Shape
    {
        public string Colour { get; set; } = string.Empty;
        // Read-only property for the area
        public abstract double Area { get; }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double Area => Math.PI * Radius * Radius;
    }

    public class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public override double Area => Width * Height;
    }

    class Program
    {
        static void Main()
        {
            // Create a list of shapes to serialize
            var listOfShapes = new List<Shape>
            {
                new Circle    { Colour = "Red",    Radius = 2.5 },
                new Rectangle { Colour = "Blue",   Height = 20.0, Width = 10.0 },
                new Circle    { Colour = "Green",  Radius = 8 },
                new Circle    { Colour = "Purple", Radius = 12.3 },
                new Rectangle { Colour = "Blue",   Height = 45.0, Width = 18.0 }
            };

            // Create an object that will format a List of Shapes as XML
            XmlSerializer xs = new(type: listOfShapes.GetType());
            // Create a file to write to
            string path = Combine(CurrentDirectory, "shapes.xml");
            using (FileStream stream = File.Create(path))
            {
                // Serialize the object graph to the stream
                xs.Serialize(stream, listOfShapes);
            }

            // Deserialize the XML file back into live objects in memory
            List<Shape>? loadedShapesXml;
            using (FileStream xmlLoad = File.Open(path, FileMode.Open))
            {
                // Deserialize and cast the object graph into a List of Shape
                loadedShapesXml = xs.Deserialize(xmlLoad) as List<Shape>;
            }

            // Output the list of shapes with their areas
            if (loadedShapesXml is not null)
            {
                
                foreach (Shape item in loadedShapesXml)
                {
                    Console.WriteLine($"{item.GetType().Name} is {item.Colour} and has an area of {item.Area}");
                }
            }
        }
    }
}

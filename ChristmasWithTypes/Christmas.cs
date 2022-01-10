using System;
namespace ChristmasWithTypes
{
    public class Christmas
    {
        public string[] Presents;
        public string[] Cars;
        public string[] Boats;
        public string[] Planes;
        public string KrisKringle { get; set; }
        public int? TreeHeight { get; set; } //DONE Make the Height Property Nullable

        //DONE Make the property, "Day", type enum
        public enum Day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday};

    }
}

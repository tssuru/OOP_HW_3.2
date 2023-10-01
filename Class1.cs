using System;

namespace HW_GeoObj_3
{
    class GeoObj
    {
        private double X, Y;
        private string _name;
        private string _description;

        public GeoObj(double x, double y, string name, string description)
        {
            X = x;
            Y = y;
            _name = name;
            _description = description;
        }

        public virtual string GetInfo()
        {
            return $"Name: {_name}\n\tCoords: X - {X} / Y - {Y};\n\tDescription: {_description}\n";
        }
    }

    class River : GeoObj
    {
        double _speed;
        double _length;
        public River(double x, double y, double speed, double length, string name, string description) : base(x, y, name, description)
        {
            _length = length;
            _speed = speed;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + "\t" + "Speed: " + _speed + "\n\t" + "Length: " + _length;
        }


    }

    class Mountain : GeoObj
    {
        double _highestPoint;
        public Mountain(double x, double y, double highestPoint, string name, string description) : base(x, y, name, description)
        {
            _highestPoint = highestPoint;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + "\t" + "Highest point: " + _highestPoint;
        }
    }
}

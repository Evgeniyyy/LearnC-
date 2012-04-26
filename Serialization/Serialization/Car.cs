﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;


namespace Serialization
{
    [Serializable]
    public class Car : ISerializable
    {
        private string make;

        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        private Owner owner;

        public Owner Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        public Car()
        {
        }

        public Car(SerializationInfo info, StreamingContext ctxt)
        {
            this.make = (string)info.GetValue("Make", typeof(string));
            this.model = (string)info.GetValue("Model", typeof(string));
            this.year = (int)info.GetValue("Year", typeof(int));
            this.owner = (Owner)info.GetValue("Owner", typeof(Owner));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("Make", this.make);
            info.AddValue("Model", this.model);
            info.AddValue("Year", this.year);
            info.AddValue("Owner", this.owner);
        }
    }
}

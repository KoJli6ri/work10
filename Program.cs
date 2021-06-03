using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil schoolboy = new Pupil("Alex");

            Console.ReadLine();
        }
    }
    public class Pupil
    {
        public string PupilName { get; private set; }

        public Pupil(string name)
        {
            PupilName = name;
        }

        private string GetPupilNameAndStatus()
        {
            return String.Format("{0} {1}", GetType().Name, PupilName);
        }

        public virtual void Read()
        {
            Console.WriteLine("{0} {1}", GetPupilNameAndStatus(), "Reading");
        }

        public virtual void Write()
        {
            Console.WriteLine("{0} {1}", GetPupilNameAndStatus(), "Writting");
        }

        public virtual void Relax()
        {
            Console.WriteLine("{0} {1}", GetPupilNameAndStatus(), "Relaxing");
        }

        public virtual void Study()
        {
            Console.WriteLine("{0} {1}", GetPupilNameAndStatus(), "Studying");
        }
    }
}

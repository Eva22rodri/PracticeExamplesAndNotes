using System;

namespace TrueCodeClassNotes
{
    class Singer : IPerform
    {
        public void Perform()
        {
            Console.WriteLine("Heres a new song");
            SingASong();
        }
        public void SingASong()
        {
            Console.WriteLine("lalalala");
        }
    }
}

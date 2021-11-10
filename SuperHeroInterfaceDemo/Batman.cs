using System;

namespace SuperHeroInterfaceDemo
{
    public class Batman : Human, IFlyable, ISeeThroughThings
    {
        public void Fly()
        {
            Console.WriteLine("I defy gravity by gliding with my cloak");
        }

        public void LookThroughObjects()
        {
            Console.WriteLine("I have use my special gadgets to get X-Ray Vision");
        }
    }


}
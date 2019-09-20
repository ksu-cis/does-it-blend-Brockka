using System;
using System.Collections.Generic;

namespace DoesItBlend
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IBlendable> blendabels = new List<IBlendable>();
            blendabels.Add(new Strawberry());
            blendabels.Add(new Banana());
            blendabels.Add(new CellPhone());
            blendabels.Add(new IceCubes());
            for(int i = 0; i<10; i++)
            {
                blendabels.Add(new Mango());
            }

            Banana b = new Banana();
            Console.WriteLine(b.Blend());
            blendabels.Add(b);
            string mess = "";
            foreach (IBlendable blendable in blendabels)
            {
                mess += blendable.Blend();
            }
            Console.WriteLine(mess);
        }
    }
}

using System;

using System.Collections.Generic;

namespace ConsoleApplication1
{

    public enum types_of_c : short{
       Informatic = 1, 
       Russian = 2,
       Math = 3,
       Physic = 4,
       Physra = 5,
       Biology = 6, 
       Geography = 7, 
      }

    public struct cab
      {
        public int num_cub;
        public types_of_c type_cub;
    
        public void DisplayInfo()
        {
            Console.WriteLine($"num_cub: {num_cub}  type: {type_cub}");
        }
    }
    

    class Program
    {
        static void Main(string[] args){
          List<cab> cabs = new List<cab>();
          var a = new cab();
          a.num_cub = 122;
          a.type_cub = types_of_c.Russian;
          cabs.Add(a);

          foreach(cab i in cabs){
            if (i.type_cub == types_of_c.Russian){
              i.DisplayInfo();
            }
          }
        }
    }
}

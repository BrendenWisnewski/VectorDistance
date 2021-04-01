using System;

namespace VectorDistance
{

    class Program
    {
        static Random rand = new Random();
        public static Points[] TwoPointArray(Random point)
        {
            Points[] vectors = new Points[100]; //create a collection of 100 sets of points using the points struct

            for (int i = 0; i < vectors.Length; i++)
            {
                vectors[i] = new Points(point);
            }

            return vectors;
        }

        public static Tuple<Points[], Points[], double> Euclidean(Points[] vectors)
        {

            Points[] pointA = new Points[1]; // this will represent the two closest points 
            Points[] pointB = new Points[1];

            double curDistance = int.MaxValue;

            foreach (var item in vectors)
            {
                for (int i = 0; i < vectors.Length - 1; i++)
                {
                    int exs = vectors[i + 1].x - vectors[i].x; //x2 - x1
                    int ys = vectors[i + 1].y - vectors[i].y;  //y2 - y1                 
                    double distance = Math.Sqrt((exs * exs) + (ys * ys)); // enter the results into the pythagorean theorem

                    if (distance <= curDistance)
                    {
                        pointA[0].x = vectors[i].x;
                        pointA[0].y = vectors[i].y;
                        
                        pointB[0].x = vectors[i + 1].x;
                        pointB[0].y = vectors[i + 1].y;
                        
                        curDistance = distance;
                    }
                }
            }
            return Tuple.Create(pointA, pointB, curDistance);
        }


      //  public static Tuple<double, double> TwoClosest(double[] input)
      //  {            
      //      Array.Sort(input);
      //
      //      return Tuple.Create(input[0], input[1]);
      //  }

        public static ThreePoints[] ThreePointArray(Random point)
        {
            ThreePoints[] threeVectors = new ThreePoints[1000];

            for (int i = 0; i < threeVectors.Length; i++)
            {
                threeVectors[i] = new ThreePoints(point);
            }

            return threeVectors;
        }

        public static Tuple<ThreePoints[], ThreePoints[], double> TripleEuclidean(ThreePoints[] threeVectors)
        {

            ThreePoints[] threePointA = new ThreePoints[1];
            ThreePoints[] threePointB = new ThreePoints[1];

            double curDistance = int.MaxValue;
            foreach (var item in threeVectors)
            {
                for (int i = 0; i < threeVectors.Length - 1; i++)
                {
                    int exs = threeVectors[i + 1].x - threeVectors[i].x;
                    int ys = threeVectors[i + 1].y - threeVectors[i].y;
                    int zs = threeVectors[i + 1].z - threeVectors[i].z;
                    double distance = Math.Sqrt((exs * exs) + (ys * ys) + (zs * zs));

                    if (distance <= curDistance)
                    {
                        threePointA[0].x = threeVectors[i].x;
                        threePointA[0].y = threeVectors[i].y;
                        threePointA[0].z = threeVectors[i].z;

                        threePointB[0].x = threeVectors[i + 1].x;
                        threePointB[0].y = threeVectors[i + 1].y;
                        threePointB[0].z = threeVectors[i + 1].z;

                        curDistance = distance;
                    }
                }
            }
            return Tuple.Create(threePointA, threePointB, curDistance); 
        }

        public static void PrintingTwo(Tuple<Points[], Points[], double> point) //using the Tuple returned from the Euclidean Method we can implement the results and print them out
        {
            string point1 = "";
            string point2 = "";

            for (int i = 0; i < point.Item1.Length; i++)
            {
                point1 = $"({point.Item1[i].x},{point.Item1[i].y})";
            }
            for (int i = 0; i < point.Item2.Length; i++)
            {
                point2 = $"({point.Item2[i].x},{point.Item2[i].y})";
            }

            Console.WriteLine($"The two closest points with two vectors are {point1} and {point2} and the distance is {point.Item3}");
        }

        public static void PrintingThree(Tuple<ThreePoints[], ThreePoints[], double> point)
        {
            string point1 = "";
            string point2 = "";
            for (int i = 0; i < point.Item1.Length; i++)
            {
                point1 = $"({point.Item1[i].x},{point.Item1[i].y},{point.Item1[i].z})";

            }
            for (int i = 0; i < point.Item2.Length; i++)
            {
                point2 = $"({point.Item2[i].x},{point.Item2[i].y},{point.Item2[i].z})";
            }
            Console.WriteLine($"The two closest points with three vectors are {point1} and {point2} and the distance is {point.Item3}");

        }


        static void Main(string[] args)
        {            
            PrintingThree(TripleEuclidean(ThreePointArray(rand)));
            PrintingTwo(Euclidean(TwoPointArray(rand)));
        }
    }
}

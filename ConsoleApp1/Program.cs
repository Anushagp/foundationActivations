using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
        class Program
        {
            public static int foundationActivation(List<int> locations)
        { 
                int N = locations.Count;
                int[] dp = new int[N];
                for (int i = 0; i < N; i++)
                {
                    dp[i] = -1;
                }

                int idxLeft;

                int idxRight;

            for (int i = 0; i < N; i++)
            {
                idxLeft = Math.Max(i - locations[i], 0);
                idxRight = Math.Min(i + (locations[i] + 1),
                                    N);
                dp[idxLeft] = Math.Max(dp[idxLeft],
                                       idxRight);
            }

                int cntfount = 1;

                int idxNext = 0;
                idxRight = dp[0];

                for (int i = 0; i < N; i++)
                {
                    idxNext = Math.Max(idxNext, dp[i]);

               
                    if (i == idxRight)
                    {
                        cntfount++;
                        idxRight = idxNext;
                    }
                }
                return cntfount;
            }

        }
    }
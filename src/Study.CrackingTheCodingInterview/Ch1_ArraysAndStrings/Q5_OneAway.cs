namespace Study.CrackingTheCodingInterview.Ch1_ArraysAndStrings
{
    // given 2 strings, check if they are one operation away from each other
    // allowed functions: add char, remove char, replace char
    //examples:
    // pale - ple = true      //ByRemove
    // pale - pales = true    //ByAdd
    // pale - bale = true     //ByReplace
    // pale - bake = false    //ByReplace
    public static class Q5_OneAway
    {

        public static bool IsOneAway(string first, string second)
        {
            if(Math.Abs(first.Length-second.Length) > 1)
                return false;

            switch (first.Length - second.Length)
            {
                case < 0: return OneAwayByAdd(first, second);
                case 0: return OneAwayByReplace(first, second);
                case > 0: return OneAwayByRemove(first, second);
            }
        }
        private static bool OneAwayByRemove(string first, string second)
        {
            int firstPointer = 0;
            int secondPointer = 0;
            bool removedFlag = false;

            while(secondPointer < second.Length)
            {
                if(first[firstPointer] != second[secondPointer])
                {
                    if (!removedFlag)
                    {
                        removedFlag = true;
                        firstPointer++;
                    }
                    else
                        return false;
                }
                else
                {
                    firstPointer++; secondPointer++;
                }
                    
            }

            return true;

        }
        private static bool OneAwayByAdd(string first, string second)
        {
            int firstPointer = 0;
            int secondPointer = 0;
            bool addFlag = false;

            while (firstPointer < first.Length)
            {
                if (first[firstPointer] != second[secondPointer])
                {
                    if (!addFlag)
                    {
                        addFlag = true;
                        secondPointer++;
                    }
                    else
                        return false;
                }
                else
                {
                    firstPointer++; secondPointer++;
                }
                
            }



            return true;
        }
        private static bool OneAwayByReplace(string first, string second)
        {
            int firstPointer = 0;
            int secondPointer = 0;
            bool replaceFlag = false;

            while (firstPointer < first.Length)
            {
                if (first[firstPointer] != second[secondPointer])
                {
                    if (!replaceFlag)
                    {
                        replaceFlag = true;
                    }
                    else
                        return false;
                }

                firstPointer++; secondPointer++;
            }

            return true;
        }
    }

}

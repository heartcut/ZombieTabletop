namespace ZombieTabletop.Shared
{
    public static class IndexLogic
    {

        public static int GenerateDiceRolls(int amount, int dicesides, int RollType)
        {

            Random rndm = new Random();

            int resultRoll = 0;

            if (RollType == 1) //Advantage Rolls
            {

                for (int i = 0; i < 2; i++)
                {
                    int totRoll = 0;
                    for (int d = 0; d < amount; d++)
                    {
                        int dice = rndm.Next(1, dicesides + 1);
                        totRoll += dice;
                    }

                    if (resultRoll < totRoll)
                    {
                        resultRoll = totRoll;
                    }
                }
                return resultRoll;
            }

            if (RollType == 0) //Standard Rolls
            {

                for (int i = 0; i < amount; i++)
                {
                    int dice = rndm.Next(1, dicesides + 1);
                    resultRoll += dice;
                }
                return resultRoll;
            }

            if (RollType == -1) //Disadvantage Rolls
            {
                resultRoll = 10000;
                for (int i = 0; i < 2; i++)
                {

                    int totRoll = 0;
                    for (int d = 0; d < amount; d++)
                    {
                        int dice = rndm.Next(1, dicesides + 1);
                        totRoll += dice;
                    }
                    if (resultRoll > totRoll)
                    {
                        resultRoll = totRoll;
                    }
                }
                return resultRoll;
            }
            
            return 0;
        }  
        
        public static string DetermineChartRoll(int dicesides, int chartType)
        {

            Random rndm = new Random();
            

            if (chartType == -2) //Unintelligent or non-aimed atk placement roll
            {
                int dice = rndm.Next(1, dicesides + 1);
                Console.WriteLine(dice);

                if (dice > 18)
                {
                    return "Head";
                }
                if (dice <= 18 & dice > 12)
                {
                    return "Torso";
                }
                if (dice <= 12 & dice > 9)
                {
                    return "Left Arm";
                }
                if (dice <= 9 & dice > 6)
                {
                    return "Right Arm";
                }
                if (dice <= 6 & dice > 3)
                {
                    return "Left Leg";
                }
                if (dice <= 3)
                {
                    return "Right Leg";
                }

            }
            return "error 02";



        }

    }
}

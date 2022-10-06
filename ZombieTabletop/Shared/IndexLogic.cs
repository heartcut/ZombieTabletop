namespace ZombieTabletop.Shared
{
    public static class IndexLogic
    {

        public static int GenerateDiceRolls(int amount,int dicesides, int AdvantageType)
        {
            
            Random rndm = new Random();
            
            int resultRoll = 0;
            
            if(AdvantageType == 1)
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
            
            if(AdvantageType == 0) 
            {

                for (int i=0; i < amount; i++)
                {
                    int dice = rndm.Next(1,dicesides+1);
                    resultRoll += dice;                    
                }         
                return resultRoll;
            }

            if (AdvantageType == -1)
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

    }
}

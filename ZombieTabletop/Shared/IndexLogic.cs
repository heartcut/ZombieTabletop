namespace ZombieTabletop.Shared
{
    public static class IndexLogic
    {

        public static int GenerateDiceRolls(int amount,int dicesides)
        {
            
            Random rndm = new Random();

            int totRoll = 0;

            for (int i=0; i < amount; i++)
            {
                int dice = rndm.Next(1,dicesides+1);

                totRoll += dice;
            }         
            return totRoll;
        }

    }
}

namespace ZombieTabletop.Shared
{
    public static class IndexLogic
    {

        public static int GenerateDiceRolls(int amount,int dicesides)
        {
            
            Random rndm = new Random();
            int totRoll = 0;

            for (int i=1; i < amount; i++)
            {
                int dice = rndm.Next();
                totRoll += dice;
            }


            return totRoll;
        }

    }
}

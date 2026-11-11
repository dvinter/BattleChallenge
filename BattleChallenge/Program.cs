// See https://aka.ms/new-console-template for more information
using BattleChallenge;
using System.Buffers;

Console.WriteLine("Start!");

Random random = new Random();

List<Monster> list = new List<Monster>() 
{
    new Monster 
    {
        Attack =  random.Next(10, 50),
        Speed = random.Next(0, 20),
        Defense = random.Next(10, 30)
    },

    new Monster
    {
        Attack =  random.Next(10, 50),
        Speed = random.Next(0, 20),
        Defense = random.Next(10, 30)
    }
};

int owner = list.IndexOf(list.OrderByDescending(x => x.Speed).ThenByDescending(x => x.Attack).First());
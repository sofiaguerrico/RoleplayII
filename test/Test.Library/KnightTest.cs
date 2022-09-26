using System;
using RoleplayGame;
using NUnit.Framework;


namespace Test.Library{
    public class KnightTest
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void TestReceiveAttackKnight()
        {

            Knight Knight2 = new Knight ("Kni2");
            Archer Archer2 = new Archer("Arc2");
            Archer2.Bow = new Bow();
            Knight2.Armor = new Armor();
            Knight2.Shield = new Shield();
            Knight2.ReceiveAttack(Archer2.AttackValue);
            
            Assert.AreEqual(94, Knight2.Health);
        }

        [Test]
        public void TestCureKnight()
        {
            Archer Archer2 = new Archer("Arc2");
            Archer2.Bow = new Bow();
            Knight Knight2 = new Knight ("Kni2");
            Knight2.Armor = new Armor();
            Knight2.Shield = new Shield();
            Knight2.ReceiveAttack(Archer2.AttackValue);
            Knight2.Cure();
            
            Assert.AreEqual(100, Knight2.Health); 
        }
    }

}
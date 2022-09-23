using NUnit.Framework;
using RoleplayGame;
using System;

namespace Test.Library
{
    public class ArcherTest
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void TestReceiveAttackArcher()
        {
            Archer Archer1 = new Archer("Nacho");
            Dwarf Dwarf1 = new Dwarf ("Nando");
            Dwarf1.Axe = new Axe();
            Archer1.ReceiveAttack(Dwarf1.AttackValue);
            
            Assert.AreEqual(75, Archer1.Health);
        }

        [Test]
        public void TestCureArcher()
        {
            Archer Archer1 = new Archer("Nacho");
            Dwarf Dwarf1 = new Dwarf ("Nando");
            Dwarf1.Axe = new Axe();
            Archer1.ReceiveAttack(Dwarf1.AttackValue);
            Archer1.Cure();
            
            Assert.AreEqual(100, Archer1.Health); 
        }
    }
}
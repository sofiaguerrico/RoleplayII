using System;
using RoleplayGame;
using NUnit.Framework;


namespace Test.Library{
    public class DwarfTest
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void TestReceiveAttackDwarf()
        {
            Dwarf Dwarf2 = new Dwarf ("Dwa2");
            Knight Knight2 = new Knight ("Kni2");
            Dwarf2.Helmet = new Helmet();
            Dwarf2.Shield = new Shield();
            Knight2.Sword = new Sword();
            Dwarf2.ReceiveAttack(Knight2.AttackValue);
            
            Assert.AreEqual(90, Dwarf2.Health);
        }

        [Test]
        public void TestCureDwarf()
        {
            Dwarf Dwarf2 = new Dwarf ("Dwa2");
            Knight Knight2 = new Knight ("Kni2");
            Dwarf2.Helmet = new Helmet();
            Dwarf2.Shield = new Shield();
            Knight2.Sword = new Sword();
            Dwarf2.ReceiveAttack(Knight2.AttackValue);
            Dwarf2.Cure();
            
            Assert.AreEqual(100, Dwarf2.Health); 
        }
    }

}
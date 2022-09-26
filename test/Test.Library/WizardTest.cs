using NUnit.Framework;
using RoleplayGame;
using System;

namespace Test.Library
{
    public class WizardTest
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void TestReceiveAttackWizard()
        {
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell() };

            Wizard Wizard1 = new Wizard("Juan");
            Knight Knight1 = new Knight ("Sofía");
            Wizard1.Staff = new Staff();
            Wizard1.SpellsBook = book;
            Knight1.Sword = new Sword();
            Wizard1.ReceiveAttack(Knight1.AttackValue);
            
            
            Assert.AreEqual(75, Wizard1.Health);
        }

        [Test]
        public void TestCureWizard()
        {

            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell() };

            Wizard Wizard1 = new Wizard("Juan");
            Knight Knight1 = new Knight ("Sofía");
            Wizard1.Staff = new Staff();
            Wizard1.SpellsBook = book;
            Knight1.Sword = new Sword();
            Wizard1.ReceiveAttack(Knight1.AttackValue);
            Wizard1.Cure();
            
            Assert.AreEqual(100, Wizard1.Health); 
        }
    }
}
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
            Wizard Wizard1 = new Wizard("Juan");
            Knight Knight1 = new Knight ("Sofía");
            Knight1.Sword = new Sword();
            Wizard1.ReceiveAttack(Knight1.AttackValue);
            
            Assert.AreEqual(80, Wizard1.Health);
        }

        [Test]
        public void TestCureWizard()
        {
            Wizard Wizard1 = new Wizard("Juan");
            Knight Knight1 = new Knight ("Sofía");
            Knight1.Sword = new Sword();
            Wizard1.ReceiveAttack(Knight1.AttackValue);
            Wizard1.Cure();
            
            Assert.AreEqual(100, Wizard1.Health); 
        }
    }
}
﻿using GeneticAlgorithm.Components.CrossoverManagers;
using GeneticAlgorithm.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeneticAlgorithm.UnitTests.Components.CrossoverManagers
{
    [TestClass]
    public class OrderCrossoverTests
    {
        private readonly ICrossoverManager crossoverManager = new OrderCrossover<string>(null, null);

        [TestMethod]
        [DataRow(20)]
        public void OrderCrossover_AllElementsInEachVector(int vectors)
        {
            crossoverManager.TestThatAllElementsInEachVector(vectors);
        }

        [TestMethod]
        public void OrderCrossover_ChildChanged()
        {
            crossoverManager.TestThatChildChanged();
        }
    }
}

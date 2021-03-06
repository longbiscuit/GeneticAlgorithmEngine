﻿namespace GeneticAlgorithm.Interfaces
{
    public interface IChildrenGenerator
    {
        IChromosome[] GenerateChildren(Population population, int number, int generation, IEnvironment environment);
    }
}
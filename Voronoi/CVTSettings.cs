﻿using System.ComponentModel;
using Voronoi.RandomEngines;
using Voronoi.StoppingCriteria;

namespace Voronoi
{
    public class CVTSettings
    {
        public int NumberOfGenerators { get; protected set; }
        public int NumberOfSamplingPoints { get; protected set; }
        public RandomEngine SelectedSamplingMethod { get; protected set; }
        public int MaxNumberOfIterations { get; protected set; }
        public IStoppingCriterion StoppingCriterion { get; protected set; }

        public CVTSettings()
        {
            InitializeDefaults();
        }

        private void InitializeDefaults()
        {
            NumberOfGenerators = 32;
            NumberOfSamplingPoints = 3000;
            SelectedSamplingMethod = RandomEngine.HALTONSEQUENCE;
            MaxNumberOfIterations = 1000;
            StoppingCriterion = new CounterDecorator(new NoDiffAfterThreeIterationsStoppingCriterion());
        }

        public static CVTSettings DefaultSettings()
        {
            return new CVTSettings();
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP_Ex02
{
    public class FeatureFactory
    {
        public enum eFeatures
        {
            WordUsageStatistics,
            MostLiked,
        }

        public static IFeature createFeature(eFeatures i_FeatureToCreate)
        {
            IFeature createdFeature = null;
            if(i_FeatureToCreate == eFeatures.WordUsageStatistics)
            {
                createdFeature = new WordUsageStatistics(); 
            }
            else if(i_FeatureToCreate == eFeatures.MostLiked)
            {
                createdFeature = new MostLikedFeature();
            }

            return createdFeature;
        }
    }
}

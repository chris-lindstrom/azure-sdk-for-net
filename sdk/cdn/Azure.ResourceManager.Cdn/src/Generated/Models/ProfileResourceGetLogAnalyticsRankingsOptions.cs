// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The ProfileResourceGetLogAnalyticsRankingsOptions. </summary>
    public partial class ProfileResourceGetLogAnalyticsRankingsOptions
    {
        /// <summary> Initializes a new instance of ProfileResourceGetLogAnalyticsRankingsOptions. </summary>
        /// <param name="rankings"> The rankings. </param>
        /// <param name="metrics"> The metrics. </param>
        /// <param name="maxRanking"> The maxRanking. </param>
        /// <param name="dateTimeBegin"> The dateTimeBegin. </param>
        /// <param name="dateTimeEnd"> The dateTimeEnd. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="rankings"/> or <paramref name="metrics"/> is null. </exception>
        public ProfileResourceGetLogAnalyticsRankingsOptions(IEnumerable<LogRanking> rankings, IEnumerable<LogRankingMetric> metrics, int maxRanking, DateTimeOffset dateTimeBegin, DateTimeOffset dateTimeEnd)
        {
            Argument.AssertNotNull(rankings, nameof(rankings));
            Argument.AssertNotNull(metrics, nameof(metrics));

            Rankings = rankings.ToList();
            Metrics = metrics.ToList();
            MaxRanking = maxRanking;
            DateTimeBegin = dateTimeBegin;
            DateTimeEnd = dateTimeEnd;
            CustomDomains = new ChangeTrackingList<string>();
        }

        /// <summary> The rankings. </summary>
        public IList<LogRanking> Rankings { get; }
        /// <summary> The metrics. </summary>
        public IList<LogRankingMetric> Metrics { get; }
        /// <summary> The maxRanking. </summary>
        public int MaxRanking { get; }
        /// <summary> The dateTimeBegin. </summary>
        public DateTimeOffset DateTimeBegin { get; }
        /// <summary> The dateTimeEnd. </summary>
        public DateTimeOffset DateTimeEnd { get; }
        /// <summary> The customDomains. </summary>
        public IList<string> CustomDomains { get; }
    }
}

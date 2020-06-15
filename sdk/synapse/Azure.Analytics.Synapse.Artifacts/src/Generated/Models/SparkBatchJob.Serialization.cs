// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class SparkBatchJob
    {
        internal static SparkBatchJob DeserializeSparkBatchJob(JsonElement element)
        {
            SparkBatchJobState livyInfo = default;
            string name = default;
            string workspaceName = default;
            string sparkPoolName = default;
            string submitterName = default;
            string submitterId = default;
            string artifactId = default;
            SparkJobType? jobType = default;
            SparkBatchJobResultType? result = default;
            SparkScheduler schedulerInfo = default;
            SparkServicePlugin pluginInfo = default;
            IReadOnlyList<SparkServiceError> errorInfo = default;
            IReadOnlyDictionary<string, string> tags = default;
            int id = default;
            string appId = default;
            IReadOnlyDictionary<string, string> appInfo = default;
            string state = default;
            IReadOnlyList<string> log = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("livyInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    livyInfo = SparkBatchJobState.DeserializeSparkBatchJobState(property.Value);
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workspaceName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workspaceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sparkPoolName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sparkPoolName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("submitterName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    submitterName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("submitterId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    submitterId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("artifactId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    artifactId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jobType = new SparkJobType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("result"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result = new SparkBatchJobResultType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("schedulerInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schedulerInfo = SparkScheduler.DeserializeSparkScheduler(property.Value);
                    continue;
                }
                if (property.NameEquals("pluginInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pluginInfo = SparkServicePlugin.DeserializeSparkServicePlugin(property.Value);
                    continue;
                }
                if (property.NameEquals("errorInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SparkServiceError> array = new List<SparkServiceError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(SparkServiceError.DeserializeSparkServiceError(item));
                        }
                    }
                    errorInfo = array;
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetString());
                        }
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("appId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetString());
                        }
                    }
                    appInfo = dictionary;
                    continue;
                }
                if (property.NameEquals("state"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("log"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    log = array;
                    continue;
                }
            }
            return new SparkBatchJob(livyInfo, name, workspaceName, sparkPoolName, submitterName, submitterId, artifactId, jobType, result, schedulerInfo, pluginInfo, errorInfo, tags, id, appId, appInfo, state, log);
        }
    }
}
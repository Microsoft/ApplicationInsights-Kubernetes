﻿namespace Microsoft.ApplicationInsights.Kubernetes.Entities
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    internal class K8sNodeImage
    {
        [JsonProperty("names")]
        public IList<string> Names { get; set; }

        [JsonProperty("sizeBytes")]
        public long SizeBytes { get; set; }
    }
}
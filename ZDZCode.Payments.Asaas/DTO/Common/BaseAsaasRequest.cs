using System.Runtime.Serialization;
using ZC.DomainModel.Core;

namespace ZDZCode.Payments.Asaas
{
    public class BaseAsaasRequest : IRestrictedByOrganization
    {
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        [IgnoreDataMember]
        public long OrganizationId { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        [IgnoreDataMember]
        public bool UseParentAccount { get; set; } = false;

        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        [IgnoreDataMember]
        public bool UseRootAccount { get; set; } = false;
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        [IgnoreDataMember]
        public long? UserId { get; set; }
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        [IgnoreDataMember]
        public bool UseOrganizationAccount { get; set; } = false;
    }

    public class BaseAsaasRequest<T> : IRestrictedByOrganization
    {
        public T Data { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        [IgnoreDataMember]
        public long OrganizationId { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        [IgnoreDataMember]
        public bool UseParentAccount { get; set; } = false;

        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        [IgnoreDataMember]
        public bool UseRootAccount { get; set; } = false;
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        [IgnoreDataMember]
        public long? UserId { get; set; }
    }
}

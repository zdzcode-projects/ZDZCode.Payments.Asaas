namespace ZDZCode.Payments.Asaas.DTO.Pix.Response
{
    public class PixKeyResponse
    {
        public string Id { get; set; }
        public string Key { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string DateCreated { get; set; }
        public bool CanBeDeleted { get; set; }
        public bool CannotBeDeletedReason { get; set; }
    }
}

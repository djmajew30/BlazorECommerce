namespace BlazorECommerce.Shared
{
    public class ProcCodes
    {
        public int pc_id { get; set; }
        public string pc_code { get; set; } = string.Empty; //need to avoid error
        public string pc_desc { get; set; } = string.Empty; //need to avoid error
    }
}

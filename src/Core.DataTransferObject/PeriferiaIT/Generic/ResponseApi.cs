namespace Core.DataTransferObject.PeriferiaIT
{
    public class ResponseApi
    {
        public bool Result { get; set; }
        public string Message { get; set; }
        public virtual object Data { get; set; }
    }
}


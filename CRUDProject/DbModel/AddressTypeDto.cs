namespace CRUDProject.DbModel
{
    public class AddressTypeDto
    {
        /// <summary>
        /// 流水號
        /// </summary>
        public int AddressTypeID { get; set; }
        /// <summary>
        /// 地址類型(住家,辦公室....)
        /// </summary>
        public string Name { get; set; }
    }
}

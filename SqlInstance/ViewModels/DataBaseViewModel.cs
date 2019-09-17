using System.ComponentModel;

namespace SqlInstance.ViewModels
{
    public class DataBaseViewModel
    {
        /// <summary>
        /// نام پایگاه داده
        /// </summary>
        [DisplayName("نام پایگاه داده")]
        public string DbName { get; set; }
    }
}

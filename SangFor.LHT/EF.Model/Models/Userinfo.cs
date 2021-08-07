using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EF.Model.Models
{
    public partial class User
    {
		[Required(AllowEmptyStrings = true)]
		[StringLength(36, ErrorMessage = "id不能超过36个字符")]
		public string UserId { get; set; }
		[Required(AllowEmptyStrings = true)]
		public string UserName { get; set; }

		[Required(AllowEmptyStrings = true)]
		public string Address { get; set; }
	}
}

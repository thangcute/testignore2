namespace Humax.ESS.Models.Task.Entities
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	//using System.Data.Entity.Spatial;

	public partial class TSK_DuAn
	{
		public int DuAnID { get; set; }

		public string MaDuAn { get; set; }

		public string TenDuAn { get; set; }

		public int? TrangThaiID { get; set; }

		public int? DuAnChaID { get; set; }

		public DateTime? NgayBatDau { get; set; }

		public DateTime? NgayKetThuc { get; set; }

		public byte? CachTinhTienDo { get; set; }

		public int? NguoiQuanTriDuAnID { get; set; }

		public string MoTa { get; set; }

		public string ImageURL { get; set; }

		public int? CreatedByID { get; set; }

		public DateTime? CreatedDate { get; set; }

		public int? ModifyByID { get; set; }

		public DateTime? ModifyDate { get; set; }
	}
}

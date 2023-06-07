namespace Humax.ESS.Models.Task.Entities
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	//using System.Data.Entity.Spatial;

	public partial class TSK_CongViec_LoaiCongViec
	{
		public int LoaiCongViecID { get; set; }

		public string MaLoaiCongViec { get; set; }

		public string TenLoaiCongViec { get; set; }

		public int? CreatedByID { get; set; }

		public DateTime? CreatedDate { get; set; }

		public int? ModifyByID { get; set; }

		public DateTime? ModifyDate { get; set; }
	}
}

namespace Humax.ESS.Models.Task.Entities
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	//using System.Data.Entity.Spatial;

	public partial class TSK_CongViec_Reminder
	{
		public int ReminderID { get; set; }

		public int? CongViecID { get; set; }

		public DateTime? ThoiGian { get; set; }

		public byte? DoiTuongNhacNho { get; set; }

		public int? Type { get; set; }
	}
}

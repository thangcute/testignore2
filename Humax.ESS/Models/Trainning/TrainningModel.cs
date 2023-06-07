using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Humax.ESS.Models.Trainning
{
    public class TrainningModel
    {
        public List<TrainningFinishedModel> Finished { get; set; }

        public List<TrainningJoinningModel> Joinning { get; set; }

        public List<TrainningOpenningModel> Openning { get; set; }
    }

    public class TrainningFinishedModel
    {
        public int Id { get; set; }
        public string TenNoiDung { get; set; }
        public DateTime? TuNgay { get; set; }
        public DateTime? ToiNgay { get; set; }
        public decimal? TongDiem { get; set; }
        public string KetQua { get; set; }
        public string NhanXet { get; set; }

        public string TaiLieu { get; set; }
    }

    public class TrainningJoinningModel
    {
        public int Id { get; set; }
        public string TenKhoaHoc { get; set; }
        public DateTime? TuNgay { get; set; }
        public DateTime? ToiNgay { get; set; }
        public decimal? SoThangCamKet { get; set; }
        public string DiaDiemDaoTao { get; set; }

        public bool? IsBatBuocThamGia { get; set; }

        public string NguoiLienHe { get; set; }
        public int? XetDuyet { get; set; }
        public int? TrangThai { get; set; }
        public List<TrainingContentModel> NoiDung { get; set; }
    }

    public class TrainningOpenningModel
    {
        public int Id { get; set; }

        public string TenKhoaHoc { get; set; }

        public DateTime? TuNgay { get; set; }

        public DateTime? ToiNgay { get; set; }

        public decimal? SoThangCamKet { get; set; }

        public string DiaDiemDaoTao { get; set; }

        public bool? IsBatBuocThamGia { get; set; }

        public string NguoiLienHe { get; set; }

        public List<TrainingContentModel> NoiDung { get; set; }

        public int? XetDuyet { get; set; }

        public string Approver { get; set; }

        public DateTime? ApprovedDate { get; set; }

        public string ApproveComment { get; set; }
    }

    public class TrainingContentModel
    {
        public int Id { get; set; }
        public string TenNoiDung { get; set; }
        public DateTime? TuNgay { get; set; }
        public DateTime? ToiNgay { get; set; }
        public decimal? TongDiem { get; set; }
        public string KetQua { get; set; }
        public string NhanXet { get; set; }
        public string TaiLieu { get; set; }
    }

    public class TrainingEvaluateModel
    {
        public int Id { get; set; }
        public string TenNoiDung { get; set; }
        public List<EvaluateModel> TieuChiDanhGia { get; set; }
    }

    public class EvaluateModel
    {
        public int Id { get; set; }
        public string NhomTieuChi { get; set; }
        public string TenTieuChi { get; set; }
        public string DanhGia { get; set; }
        public string KieuDuLieu { get; set; }
        public string GhiChu { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplikasiPenilaianMahasiswa.Api.DataModel;
using ApplikasiPenilaianMahasiswa.Api.Excel;
using ApplikasiPenilaianMahasiswa.Api.Security;
using ViewModel;

namespace ApplikasiPenilaianMahasiswa.Api.Repositories
{
    public class HomeRepositories
    {
        private MahasiswaDbContext _dbContext;
        private ResponseResult _result = new ResponseResult();
        public HomeRepositories(MahasiswaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ResponseResult Upload(string filePath)
        {
            try
            {
                var announcement = ExcelHelper.Import<AnnouncementViewModel>(filePath);
                foreach (var announcementItem in announcement)
                {
                    var announceEntity = new Announcement
                    {
                        Title = announcementItem.Title,
                        Content = announcementItem.Content,
                        Created_by = ClaimsContext.UserName(),
                        Created_on = DateTime.Now
                    };
                    _dbContext.Announcements.Add(announceEntity);
                }
                _dbContext.SaveChanges();
                _result.Success = true;
                _result.Message = "Upload Success";
            }
            catch (Exception e)
            {
                _result.Success = false;
                _result.Message = e.ToString();
            }

            return _result;
        }
    }
}
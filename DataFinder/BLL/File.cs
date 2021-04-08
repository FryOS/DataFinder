using DataFinder.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFinder.BLL
{
    public class File
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }

        public File(FileEntity fileEntity)
        {
            this.Id = fileEntity.Id;
            this.Name = fileEntity.Name;
            this.Path = fileEntity.Path;
        }
    }
}

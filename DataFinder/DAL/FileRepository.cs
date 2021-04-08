using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFinder.DAL
{
    public class FileRepository
    {
        private IEnumerable<FileEntity> _files { get; }

        public FileRepository()
        {
            _files = new List<FileEntity>()
            { 
                new FileEntity(Guid.NewGuid(), "Реферат.docx", "C:/Desktop/Docs/Реферат.docx"),
                new FileEntity(Guid.NewGuid(), "Отчет.docx", "C:/Desktop/Docs/Отчет.docx"),
                new FileEntity(Guid.NewGuid(), "Книга.xls", "C:/Desktop/Docs/Книга.xls"),
                new FileEntity(Guid.NewGuid(), "Фото.jpeg", "C:/Desktop/Docs/Фото.jpeg")

            };
        }

        public IEnumerable<FileEntity> GetFilesByDirectory()
        {
            return this._files;
        }

        public FileEntity GetFileByFileName(string fileName)
        {
            return this._files.FirstOrDefault(file => file.Name == fileName);
        }
    }
}

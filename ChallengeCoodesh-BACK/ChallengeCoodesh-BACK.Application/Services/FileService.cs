using ChallengeCoodesh_BACK.Domain.Entities;
using ChallengeCoodesh_BACK.Domain.Enum;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeCoodesh_BACK.Application.Services
{
    public class FileService
    {

        public List<FileUploader> SerializerFile(string fileTxt)
        {
            List<FileUploader> fileUploaderList = new();
            using (StringReader reader = new StringReader(fileTxt))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrEmpty(line))
                        continue;

                    var typeEnum = (TypeTransaction)Enum.Parse(typeof(TypeTransaction), line.Substring(0, 1));
                    var date = Convert.ToDateTime(line.Substring(1, 26));
                    var productDescription = line.Substring(26, 30);
                    var value = line.Substring(56, 10);
                    var saller = line.Substring(66);
                    FileUploader file = new(typeEnum, date, productDescription, Decimal.Parse(value.TrimStart('0')), saller);

                    fileUploaderList.Add(file);
                }
            }

            return fileUploaderList;
        }

        public string Base64ToString(string fileBase64)
        {
            byte[] dadosAsBytes = System.Convert.FromBase64String(fileBase64);
            string resultado = System.Text.ASCIIEncoding.ASCII.GetString(dadosAsBytes);
            return resultado;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemulaiDatabase.Models
{
    public class MahasiswaModel
    {
        public int Id { get; set; }
        public string NPM { get; set; }
        public string NamaMahasiswa { get; set; }
        public string Email { get; set; }
        public string Alamat { get; set; }
        public string JenisKelamin { get; set; }
    }
}

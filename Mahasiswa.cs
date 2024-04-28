using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul10_1302220024
{
    public class Mahasiswa
    {
        public string Nama { get; set; }
        public string NIM { get; set; }

        public Mahasiswa(string Nama, string NIM)
        {
            this.Nama = Nama;
            this.NIM = NIM;
        }
    }
}

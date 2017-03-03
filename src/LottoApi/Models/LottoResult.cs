using System;
using System.ComponentModel.DataAnnotations;

namespace LottoApi.Models
{
    public class LottoResult
    {
        [Key]
        public long Key { get; set; }

        public string LottoGameName { get; set; }

        public string Combination { get; set; }

        public DateTime DrawDate { get; set; }

        public decimal JackpotPrize { get; set; }

        public int Winners { get; set; }
    }
}

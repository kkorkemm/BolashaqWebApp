using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BolashaqWebApp.Models
{
    public partial class Kruzhok
    {
        public string PriceString => Price == 0 ? "Бесплатно" : Price.ToString() + " тг";
        public string Image => "data:image;base64," + Convert.ToBase64String(KruzhokPictures.ToList().FirstOrDefault().Image);

        public int ZayavkaCount => Zayavka.Count;
    }
}
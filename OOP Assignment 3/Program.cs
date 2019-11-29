/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2014-2015 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: G181210017
**				ÖĞRENCİ ADI............: SALİH EREN DEĞİRMENCİ
**				ÖĞRENCİ NUMARASI.......: G181210017 
**              DERSİN ALINDIĞI GRUP...: D
****************************************************************************/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV_3_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Operator Opr_1 = new Operator();
           
            
            //Run Calculate function
            do
            {
                Opr_1.Calculate();
                

            } while (Opr_1.restarter);
        }
    }
}

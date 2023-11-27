using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;


namespace AISLab67
{
    public class Parser
    {
        private string html = @"https://tpu.ru/university/schools/";
        public List<Model.School> GetSchools()
        {
            List<Model.School> Schools = new List<Model.School>();

            HtmlWeb htmlWeb = new HtmlWeb();
            HtmlDocument htmlDoc = new HtmlDocument();
            try
            {
                htmlDoc = htmlWeb.Load(html);
            }
            catch
            {
                throw;
            }
            HtmlNodeCollection article = htmlDoc.DocumentNode.SelectNodes("//article[@class='school']");

            foreach (HtmlNode school in article)
            {
                string name = school.SelectNodes("./header/h2").First().InnerText;
                name = name.Replace("\n", "").Replace("\r", " ");
                string phone = school.SelectNodes(".//div[@class='school-contact__item']/a").First().InnerText;
                string campus = school.SelectNodes(".//div[@class='school-contact__item']/address/strong").First().InnerText.Trim();
                string address = school.SelectNodes(".//div[@class='school-contact__item']/address").First().InnerText.Replace(campus, "").Trim();
               // address = address.Trim();
                Model.School School = new Model.School
                {
                    Address = address,
                    Phone = phone,
                    Name = name,
                    Campus = campus
                };
                Schools.Add(School);
            }
            return Schools;
        }

    }
}

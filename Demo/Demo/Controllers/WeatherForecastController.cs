using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Demo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var myPresentation = new
            {
                title = "Postman y sus Bondades",
                description = "Veremos las bondades de Postman",
                speaker = "Christian Sánchez",
                bio = "Software Engineer & Auth0 Ambassador",
                codeExample = "https://github.com/christiansc96/Postman-and-his-benefits",
                communities = new List<object>
                {
                    new
                    {
                        DevTeam504 = "Co-Fundador y Organizador",
                        FlutterHonduras = "Co-Fundador y Co-Organizer",
                        GoogleDSCUNAHVS = "Google DSC Lead"
                    }
                },
                socialMedia = new
                {
                    twitter = new
                    {
                        user = "@christian_sc96",
                        profile = "https://twitter.com/christian_sc96"
                    },
                    github = new
                    {
                        user = "@christiansc96",
                        profile = "https://github.com/christiansc96"
                    },
                    instagram = new
                    {
                        user = "@christian_sc96",
                        profile = "https://www.instagram.com/christian_sc96/"
                    },
                    linkedin = new
                    {
                        user = "Christian Sánchez",
                        profile = "https://www.linkedin.com/in/christian-david-s%C3%A1nchez-675980177/"
                    }
                }
            };
            return Ok(myPresentation);
        }
    }
}
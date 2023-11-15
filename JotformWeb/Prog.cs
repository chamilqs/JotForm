using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JotForm;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JotFormTest
{
    class Prog
    {
        static async Task Main(string[] args)
        {
            var client = new JotForm.APIClient("e62e435c907db1206be507454c7dea1b");
            var user = client.getFormSubmissons(233176380006854);



        }
    }
}

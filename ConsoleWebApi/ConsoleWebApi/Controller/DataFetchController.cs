using ConsoleWebApi.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

//using WebAPI_FetchData.Model;

namespace ConsoleWebApi.Controllers
{
    [Route("api/[controller]")]
    public class DataFetchController : ApiController

    {
        Data DataObj = new Data();
        public List<Data> DataList = new List<Data>();
        public static string Filepath = @"D:\SQL ,C# Programs\C#\My Programs\WebApi\Data.txt";
        List<string> lines = File.ReadAllLines(Filepath).ToList();
        public List<Data> AddToList()
        {
            foreach (var lines in lines )
            {
                string[] entries = lines.Split('|');
                DataObj.FirstName = entries[0];
                DataObj.SecondName = entries[1];
                DataObj.EmailId = entries[2];
                DataObj.Gender = entries[3];
                DataObj.Dob = DateTime.ParseExact(entries[4], "dd-mm-yyyy", CultureInfo.InvariantCulture);

                DataList.Add(DataObj);
            }
            return DataList;
        }
        //GET API VALUESS
        [HttpGet]
        public List<Data> Get()
        {
            //string param = string.Empty;
            //AddToList(param);
            List<Data> getList = AddToList();
            return getList;
        }
        [HttpGet]
        public IHttpActionResult Get(string FirstName)
        {
            //string param = string.Empty;
            var product = AddToList().Where(x => x.FirstName == FirstName).ToList();
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}

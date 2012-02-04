using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var products = GetProducts();
            GridView1.DataSource = products;
            GridView1.DataBind();
        }

        public IQueryable<NorthwindService.Supplier> GetProducts()
        {
            var service = new NorthwindService.DemoService(new Uri(@"http://services.odata.org/OData/OData.svc/"));
            var suppliers = (from p in service.Suppliers
                             select p);
            return suppliers;
        }
    }

    
}

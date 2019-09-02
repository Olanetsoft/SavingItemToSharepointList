using System;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;

namespace SharepointCRUDoperation.Layouts
{
    public partial class SaveToList : LayoutsPageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        //The method below enables items to be saved to a list on each column
        public void saveToList()
        {
            //connect to the web site
            using (SPSite theSite = new SPSite("url"))
            {
                //opens the site 
                using (SPWeb theWeb = theSite.OpenWeb())
                {
                    //connects to a list
                    SPList list = theWeb.Lists["Sharepoint List"];
                    SPListItem item = list.AddItem();


                    //this section below saves question into the list

                    item["Column1"] = TextBox1.Text;
                    item["Column2"] = TextBox2.Text;
                    item["Column3"] = TextBox3.Text;
                    item["Column4"] = TextBox4.Text;
                    item["Column5"] = TextBox5.Text;
                    item["Column6"] = TextBox6.Text;

                    item.Update();



                }
            }
        }
    }
}

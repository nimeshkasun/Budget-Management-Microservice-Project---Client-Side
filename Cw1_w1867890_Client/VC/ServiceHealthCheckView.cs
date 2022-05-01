using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Cw1_w1867890.VC
{
    public partial class ServiceHealthCheckView : Form
    {
        Boolean API_Gateway = false;
        Boolean API_Cat = false;
        Boolean API_Tran = false;
        Boolean Service_Cat = false;
        Boolean Service_Tran = false;
        HttpWebRequest lObjReq;

        public ServiceHealthCheckView()
        {
            InitializeComponent();
            setDefTextAndIcon();

        }

        private void setDefTextAndIcon()
        {
            try
            {
                pbStatusAPIGateway.Image = Bitmap.FromHicon(new Icon(SystemIcons.Question, 20, 20).Handle);
                pbStatusAPIGatewayCategory.Image = Bitmap.FromHicon(new Icon(SystemIcons.Question, 20, 20).Handle);
                pbStatusAPIGatewayTransaction.Image = Bitmap.FromHicon(new Icon(SystemIcons.Question, 20, 20).Handle);
                pbStatusServiceCategory.Image = Bitmap.FromHicon(new Icon(SystemIcons.Question, 20, 20).Handle);
                pbStatusServiceTransaction.Image = Bitmap.FromHicon(new Icon(SystemIcons.Question, 20, 20).Handle);
                pbStatusAllServices.Image = Bitmap.FromHicon(new Icon(SystemIcons.Question, 20, 20).Handle);

                lblStatusAPIGateway.Text = "Cheking...";
                lblStatusAPIGatewayCategory.Text = "Cheking...";
                lblStatusAPIGatewayTransaction.Text = "Cheking...";
                lblStatusServiceCategory.Text = "Cheking...";
                lblStatusServiceTransaction.Text = "Cheking...";
                lblStatusAllServices.Text = "Cheking...";
            }
            catch (Exception ex)
            {

            }
        }

        private void checkAPIconnectionAllServices()
        {
            if (API_Gateway)
            {
                if (API_Cat)
                {
                    if (API_Tran)
                    {
                        if (Service_Cat)
                        {
                            if (Service_Tran)
                            {
                                lblStatusAllServices.Text = "All Services Online";
                                lblStatusAllServices.ForeColor = Color.Green;
                                pbStatusAllServices.Image = Bitmap.FromHicon(new Icon(SystemIcons.Shield, 20, 20).Handle);
                            }
                            else
                            {
                                lblStatusAllServices.Text = "One or More Services Down";
                                lblStatusAllServices.ForeColor = Color.Red;
                                pbStatusAllServices.Image = Bitmap.FromHicon(new Icon(SystemIcons.Error, 20, 20).Handle);
                            }
                        }
                        else
                        {
                            lblStatusAllServices.Text = "One or More Services Down";
                            lblStatusAllServices.ForeColor = Color.Red;
                            pbStatusAllServices.Image = Bitmap.FromHicon(new Icon(SystemIcons.Error, 20, 20).Handle);
                        }
                    }
                    else
                    {
                        lblStatusAllServices.Text = "One or More Services Down";
                        lblStatusAllServices.ForeColor = Color.Red;
                        pbStatusAllServices.Image = Bitmap.FromHicon(new Icon(SystemIcons.Error, 20, 20).Handle);
                    }
                }
                else
                {
                    lblStatusAllServices.Text = "One or More Services Down";
                    lblStatusAllServices.ForeColor = Color.Red;
                    pbStatusAllServices.Image = Bitmap.FromHicon(new Icon(SystemIcons.Error, 20, 20).Handle);
                }
            }
            else
            {
                lblStatusAllServices.Text = "One or More Services Down";
                lblStatusAllServices.ForeColor = Color.Red;
                pbStatusAllServices.Image = Bitmap.FromHicon(new Icon(SystemIcons.Error, 20, 20).Handle);
            }

        }


        private void OnRefreshHealth(object sender, EventArgs e)
        {
            btnRefreshHealth.Enabled = false;
            setDefTextAndIcon();

            lblStatusAPIGateway.Text = "Running...";
            System.Threading.Thread.Sleep(3000);
            try
            {            
                //String Http_URL_API_Gateway = HttpUtility.UrlDecode("https://iiteadcw2.azure-api.net/");
                String Http_URL_API_Gateway = HttpUtility.UrlDecode("https://iitead.azure-api.net");
                lObjReq = (HttpWebRequest)HttpWebRequest.Create(Http_URL_API_Gateway);
                lObjReq.Timeout = 12000;
                lObjReq.UseDefaultCredentials = true;
                if (lObjReq.GetResponse().ContentLength > 0)
                {
                    API_Gateway = true;
                    lblStatusAPIGateway.Text = "API Gateway Service Online";
                    lblStatusAPIGateway.ForeColor = Color.Green;
                    pbStatusAPIGateway.Image = Bitmap.FromHicon(new Icon(SystemIcons.Shield, 20, 20).Handle);
                }
                else
                {
                    lblStatusAPIGateway.Text = "API Gateway Service Down or Timed out";
                    lblStatusAPIGateway.ForeColor = Color.Red;
                    pbStatusAPIGateway.Image = Bitmap.FromHicon(new Icon(SystemIcons.Error, 20, 20).Handle);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                lblStatusAPIGateway.Text = "API Gateway Service Down or Timed out";
                lblStatusAPIGateway.ForeColor = Color.Red;
                pbStatusAPIGateway.Image = Bitmap.FromHicon(new Icon(SystemIcons.Error, 20, 20).Handle);
            }


            lblStatusAPIGatewayCategory.Text = "Running...";
            System.Threading.Thread.Sleep(3000);
            try
            {
                String Http_URL_API_Cat = HttpUtility.UrlDecode("https://iiteadcw2.azure-api.net/s1/Category/");
                //String Http_URL_API_Cat = HttpUtility.UrlDecode("https://iitead.azure-api.net/s1/Category/");
                lObjReq = (HttpWebRequest)HttpWebRequest.Create(Http_URL_API_Cat);
                lObjReq.Timeout = 12000;
                lObjReq.UseDefaultCredentials = true;
                if (lObjReq.GetResponse().ContentLength > 0)
                {
                    API_Cat = true;
                    lblStatusAPIGatewayCategory.Text = "API Gateway Category Service Online";
                    lblStatusAPIGatewayCategory.ForeColor = Color.Green;
                    pbStatusAPIGatewayCategory.Image = Bitmap.FromHicon(new Icon(SystemIcons.Shield, 20, 20).Handle);
                }
                else
                {
                    lblStatusAPIGatewayCategory.Text = "API Gateway Category Service Down or Timed out";
                    lblStatusAPIGatewayCategory.ForeColor = Color.Red;
                    pbStatusAPIGatewayCategory.Image = Bitmap.FromHicon(new Icon(SystemIcons.Error, 20, 20).Handle);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                lblStatusAPIGatewayCategory.Text = "API Gateway Category Service Down or Timed out";
                lblStatusAPIGatewayCategory.ForeColor = Color.Red;
                pbStatusAPIGatewayCategory.Image = Bitmap.FromHicon(new Icon(SystemIcons.Error, 20, 20).Handle);
            }


            lblStatusAPIGatewayTransaction.Text = "Running...";
            System.Threading.Thread.Sleep(3000);
            try
            {
                String Http_URL_API_Tran = HttpUtility.UrlDecode("https://iiteadcw2.azure-api.net/s2/Transaction/");
                //String Http_URL_API_Tran = HttpUtility.UrlDecode("https://iitead.azure-api.net/s2/Transaction/");
                lObjReq = (HttpWebRequest)HttpWebRequest.Create(Http_URL_API_Tran);
                lObjReq.Timeout = 12000;
                lObjReq.UseDefaultCredentials = true;
                if (lObjReq.GetResponse().ContentLength > 0)
                {
                    API_Tran = true;
                    lblStatusAPIGatewayTransaction.Text = "API Gateway Transaction Service Online";
                    lblStatusAPIGatewayTransaction.ForeColor = Color.Green;
                    pbStatusAPIGatewayTransaction.Image = Bitmap.FromHicon(new Icon(SystemIcons.Shield, 20, 20).Handle);
                }
                else
                {
                    lblStatusAPIGatewayTransaction.Text = "API Gateway Transaction Service Down or Timed out";
                    lblStatusAPIGatewayTransaction.ForeColor = Color.Red;
                    pbStatusAPIGatewayTransaction.Image = Bitmap.FromHicon(new Icon(SystemIcons.Error, 20, 20).Handle);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                lblStatusAPIGatewayTransaction.Text = "API Gateway Transaction Service Down or Timed out";
                lblStatusAPIGatewayTransaction.ForeColor = Color.Red;
                pbStatusAPIGatewayTransaction.Image = Bitmap.FromHicon(new Icon(SystemIcons.Error, 20, 20).Handle);
            }


            lblStatusServiceCategory.Text = "Running...";
            System.Threading.Thread.Sleep(3000);
            try
            {
                String Http_URL_Service_Cat = HttpUtility.UrlDecode("https://iiteadcw2categoryservice.azurewebsites.net/Category/");
                lObjReq = (HttpWebRequest)HttpWebRequest.Create(Http_URL_Service_Cat);
                lObjReq.Timeout = 12000;
                lObjReq.UseDefaultCredentials = true;
                if (lObjReq.GetResponse().ContentLength > 0)
                {
                    Service_Cat = true;
                    lblStatusServiceCategory.Text = "Category Service Endpoint Online";
                    lblStatusServiceCategory.ForeColor = Color.Green;
                    pbStatusServiceCategory.Image = Bitmap.FromHicon(new Icon(SystemIcons.Shield, 20, 20).Handle);
                }
                else
                {
                    lblStatusServiceCategory.Text = "Category Service Endpoint Down or Timed out";
                    lblStatusServiceCategory.ForeColor = Color.Red;
                    pbStatusServiceCategory.Image = Bitmap.FromHicon(new Icon(SystemIcons.Error, 20, 20).Handle);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                lblStatusServiceCategory.Text = "Category Service Endpoint Down or Timed out";
                lblStatusServiceCategory.ForeColor = Color.Red;
                pbStatusServiceCategory.Image = Bitmap.FromHicon(new Icon(SystemIcons.Error, 20, 20).Handle);
            }


            lblStatusServiceTransaction.Text = "Running...";
            System.Threading.Thread.Sleep(3000);
            try
            {
                String Http_URL_Service_Tran = HttpUtility.UrlDecode("https://iiteadcw2transactionservice.azurewebsites.net/Transaction");
                lObjReq = (HttpWebRequest)HttpWebRequest.Create(Http_URL_Service_Tran);
                lObjReq.Timeout = 12000;
                lObjReq.UseDefaultCredentials = true;
                if (lObjReq.GetResponse().ContentLength > 0)
                {
                    Service_Tran = true;
                    lblStatusServiceTransaction.Text = "Transaction Service Endpoint Online";
                    lblStatusServiceTransaction.ForeColor = Color.Green;
                    pbStatusServiceTransaction.Image = Bitmap.FromHicon(new Icon(SystemIcons.Shield, 20, 20).Handle);
                }
                else
                {
                    lblStatusServiceTransaction.Text = "Transaction Service Endpoint Down or Timed out";
                    lblStatusServiceTransaction.ForeColor = Color.Red;
                    pbStatusServiceTransaction.Image = Bitmap.FromHicon(new Icon(SystemIcons.Error, 20, 20).Handle);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                lblStatusServiceTransaction.Text = "Transaction Service Endpoint Down or Timed out";
                lblStatusServiceTransaction.ForeColor = Color.Red;
                pbStatusServiceTransaction.Image = Bitmap.FromHicon(new Icon(SystemIcons.Error, 20, 20).Handle);
            }


            lblStatusAllServices.Text = "Running...";
            checkAPIconnectionAllServices();

            //btnRefreshHealth.Enabled = true;
        }
    }
}

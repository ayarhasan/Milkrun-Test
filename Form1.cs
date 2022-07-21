using MilkrunTest.Objects;
using Newtonsoft.Json;
using RestSharp;
using System.Net;

namespace MilkrunTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Token token;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            clearlists();
            var client = new RestClient(txtUrl.Text);
            var request = new RestRequest(txtUrl.Text + "/api/token", Method.Post);

            request.AddHeader("cache-control", "no-cache");
            request.AddParameter("Content-Type", "application/x-www-form-urlencoded", ParameterType.HttpHeader);
            string encodedBody = string.Format("username={0}&password={1}&grant_type={2}", txtUserName.Text, txtPassword.Text, "password");
            request.AddParameter("application/x-www-form-urlencoded", encodedBody, ParameterType.RequestBody);


            var response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                txtToken.Text = response.Content;

                token = JsonConvert.DeserializeObject<Token>(response.Content);
                loadMasterWareHouses();
                loadStores();
                loadTodoList();
            }
            else
            {
                MessageBox.Show(response.Content);
            }
        }

        private void clearlists()
        {
            lstMainWareHouse.Items.Clear();
            lstStore.Items.Clear();
            lstTodoList.Items.Clear();
        }

        void loadMasterWareHouses()
        {
            var retbody = GetListRequest("New_CustomerPoint", "<e id=\"202200004\" ><Attribute attributeid=\"71b6e157-be54-47af-8599-cef3785b46f3\" id=\"\" objectId=\"202200004\" text=\"\" type=\"Attribute\" entityobjectid=\"202200004\" conditionvalue=\"0184ce2e-3404-41ac-984b-3e5c7d93a27f\" objectAlias=\"Mt\"/></e>");
            if (retbody != string.Empty)
            {
                var list = JsonConvert.DeserializeObject<New_CustomerPointView>(retbody);
                if (list != null && list.Records.Count > 0)
                {
                    foreach (New_CustomerPoint? rec in list.Records)
                    {
                        lstMainWareHouse.Items.Add(rec);
                    }
                }
            }
        }
        void loadStores()
        {
            var retbody = GetListRequest("New_CustomerPoint", "<Entity202200004 id=\"202200004\" objectid=\"202200004\" text=\"\" attributeid=\"\" leftjoin=\"false\" type=\"0\"><Attribute attributeid=\"570e7bfc-6ae9-4e45-8b17-6dd8a16d3241\" id=\"\" objectId=\"202200004\" text=\"\" type=\"Attribute\" entityobjectid=\"202200004\" conditionvalue=\"85d01f29-40a6-4d62-9f8b-065a05c94b65\" clausevalue=\"2\" clausetext=\"Mağaza\" conditiontype=\"1\" clausevalue2=\"\" objectAlias=\"Mt\"/></Entity202200004>");
            if (retbody != string.Empty)
            {
                var list = JsonConvert.DeserializeObject<New_CustomerPointView>(retbody);
                if (list != null && list.Records.Count > 0)
                {
                    foreach (New_CustomerPoint? rec in list.Records)
                    {
                        lstStore.Items.Add(rec);
                    }
                }
            }
        }
        void loadTodoList()
        {
            var retbody = GetListRequest("New_BoxTransactions", "<Entity202200010 id=\"202200010\" objectid=\"202200010\" text=\"\" attributeid=\"\" leftjoin=\"false\" type=\"0\"><Attribute attributeid=\"17e93957-ea2e-4529-9d4f-5777d427f38a\" id=\"\" objectId=\"202200010\" text=\"\" type=\"Attribute\" entityobjectid=\"202200010\" conditionvalue=\"c721ca87-7155-43aa-bd82-0a596a2da0cc\" clausevalue=\"\" clausetext=\"\" conditiontype=\"1\" clausevalue2=\"\" objectAlias=\"Mt\"/></Entity202200010>");
            if (retbody != string.Empty)
            {
                var list = JsonConvert.DeserializeObject<New_BoxTransactionView>(retbody);
                if (list != null && list.Records.Count > 0)
                {
                    foreach (New_BoxTransaction? rec in list.Records)
                    {
                        lstTodoList.Items.Add(rec);
                    }
                }
            }
        }
        string GetListRequest(string entityName, string filter)
        {
            var client = new RestClient(txtUrl.Text);
            var request = new RestRequest(txtUrl.Text + "/dapi/DynamicEntity/List/" + entityName + "?filterquery=" + filter, Method.Get);

            request.AddHeader("cache-control", "no-cache");
            request.AddParameter("Content-Type", "application/x-www-form-urlencoded", ParameterType.HttpHeader);
            request.AddHeader("authorization", $"Bearer {token.access_token}");

            var response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {

                return response.Content;

            }
            else
            {
                MessageBox.Show(response.Content);
            }
            return string.Empty;
        }

        private void btnBoxAccept_Click(object sender, EventArgs e)
        {
            if (lstMainWareHouse.SelectedItem == null)
            {
                MessageBox.Show("Lütfen ana depo seçiniz");

            }
            else
            {
                var frm = new ActionWindow();
                if (frm.ShowDialog() == DialogResult.OK)
                {



                    var client = new RestClient(txtUrl.Text);
                    var request = new RestRequest(txtUrl.Text + "/dapi/Transaction/BoxAccept", Method.Post);

                    request.AddHeader("cache-control", "no-cache");
                    request.AddParameter("Content-Type", "application/json", ParameterType.HttpHeader);
                    request.AddHeader("authorization", $"Bearer {token.access_token}");

                    List<BoxAccept> acceptList = new List<BoxAccept>();
                    acceptList.Add(new BoxAccept()
                    {
                        DeliveryNote = frm.DeliveryNote,
                        MilkrunProductCode = "LogD-M001",/*Logd kutu kodu*/
                        Quantity = frm.Quantity,
                        TransactionDateTime = DateTime.Now,
                        WarehouseCode = ((New_CustomerPoint)lstMainWareHouse.SelectedItem).ErpCode

                    });
                    string encodedBody = JsonConvert.SerializeObject(acceptList);
                    request.AddParameter("application/json", encodedBody, ParameterType.RequestBody);

                    var response = client.Execute(request);
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        MessageBox.Show("Depoya Giriş Emri Verildi");

                    }
                }
            }

        }

        private void btnSenMaintoStore_Click(object sender, EventArgs e)
        {
            Send(lstMainWareHouse, lstStore);

        }

        private void btnSendStoreToMain_Click(object sender, EventArgs e)
        {
            Send(lstStore, lstMainWareHouse);
        }

        public void Send(ListBox from, ListBox to)
        {
            if (from.SelectedItem == null || to.SelectedItem == null)
            {
                MessageBox.Show("Lütfen  depoları seçiniz");

            }
            else
            {
                var frm = new ActionWindow();
                if (frm.ShowDialog() == DialogResult.OK)
                {



                    var client = new RestClient(txtUrl.Text);
                    var request = new RestRequest(txtUrl.Text + "/dapi/Transaction/Transfer", Method.Post);

                    request.AddHeader("cache-control", "no-cache");
                    request.AddParameter("Content-Type", "application/json", ParameterType.HttpHeader);
                    request.AddHeader("authorization", $"Bearer {token.access_token}");

                    List<Transfer> acceptList = new List<Transfer>();
                    acceptList.Add(new Transfer()
                    {
                        DeliveryNote = frm.DeliveryNote,
                        MilkrunProductCode = "LogD-M001",
                        Quantity = frm.Quantity,
                        TransactionDateTime = DateTime.Now,
                        FromWarehouseCode = ((New_CustomerPoint)from.SelectedItem).ErpCode,
                        ToWarehouseCode = ((New_CustomerPoint)to.SelectedItem).ErpCode

                    });
                    string encodedBody = JsonConvert.SerializeObject(acceptList);
                    request.AddParameter("application/json", encodedBody, ParameterType.RequestBody);

                    var response = client.Execute(request);
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        MessageBox.Show("Transfer İş Emri Verildi");

                    }
                    else
                    {
                        MessageBox.Show(response.ErrorMessage);
                    }
                }
            }
        }

        private void btnTransferAcceptByDeliveryNote_Click(object sender, EventArgs e)
        {
            if (lstTodoList.SelectedItem == null)
            {
                MessageBox.Show("Lütfen  depoları seçiniz");

            }
            else
            {
                var client = new RestClient(txtUrl.Text);
                var request = new RestRequest(txtUrl.Text + "/dapi/Transaction/TransferAcceptByDeliveryNote", Method.Post);

                request.AddHeader("cache-control", "no-cache");
                request.AddParameter("Content-Type", "application/json", ParameterType.HttpHeader);
                request.AddHeader("authorization", $"Bearer {token.access_token}");
                var accept = new TransferAcceptByDeliveryNote()
                {
                    DeliveryNote = ((New_BoxTransaction)lstTodoList.SelectedItem).DeliveryNote,
                    TransactionDateTime = DateTime.Now,
                    WarehouseCode = ((New_BoxTransaction)lstTodoList.SelectedItem).ToWarehouseCode

                };
                string encodedBody = JsonConvert.SerializeObject(accept);
                request.AddParameter("application/json", encodedBody, ParameterType.RequestBody);

                var response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    MessageBox.Show("Kabül İş Emri Verildi");
                    RefreshTodoList();
                }
                else
                {
                    MessageBox.Show(response.ErrorMessage);
                }
            }
        }
        void RefreshTodoList()
        {
            lstTodoList.Items.Clear();
            loadTodoList();
        }

        private void RefreshList_Click(object sender, EventArgs e)
        {
            RefreshTodoList();
        }

        string GetWarehouseDetail(New_CustomerPoint pc)
        {
            var msg = string.Empty;

            var retbody = GetListRequest("New_CustomerPointProductCount", $"<Entity202200020 id=\"202200020\" objectid=\"202200020\" text=\"\" attributeid=\"\" leftjoin=\"false\" type=\"0\"><Attribute attributeid=\"f8e97bf9-175f-4857-8072-6a4c1512100c\" id=\"\" objectId=\"202200020\" text=\"\" type=\"Attribute\" entityobjectid=\"202200020\" conditionvalue=\"85d01f29-40a6-4d62-9f8b-065a05c94b65\" clausevalue=\"{pc.ID}\" conditiontype=\"1\" clausevalue2=\"\" objectAlias=\"Mt\"/></Entity202200020> ");
            if (retbody != string.Empty)
            {
                var list = JsonConvert.DeserializeObject<New_CustomerPointProductCountView>(retbody);
                if (list != null && list.Records.Count > 0)
                {
                    foreach (New_CustomerPointProductCount? rec in list.Records)
                    {
                        msg += rec.ToString(); ;
                    }
                }
            }
            return msg;
        }
        private void lstMainWareHouse_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(GetWarehouseDetail((New_CustomerPoint)lstMainWareHouse.SelectedItem),"Depo stoğu");
        }

        private void lstStore_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(GetWarehouseDetail((New_CustomerPoint)lstStore.SelectedItem), "Depo stoğu");
        }
    }


}
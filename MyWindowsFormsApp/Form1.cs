using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace MyWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public string filePath = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Displays an OpenFileDialog so the user can select a Cursor.  
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Any Files|*.*";
            openFileDialog1.Title = "Select any File";

            // Show the Dialog.  
            // If the user clicked OK in the dialog and  
            // a .CUR file was selected, open it.  
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Assign the cursor in the Stream to the Form's Cursor property.  
                //this.Cursor = new Cursor(openFileDialog1.OpenFile());
                openfile.Text = openFileDialog1.FileName;
                filePath = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Helper helper = new Helper();
            string hash = string.Empty;
            string sign = string.Empty;

            using (MD5 md5Hash = MD5.Create())
            {
                hash = helper.GetMd5Hash(md5Hash, filePath);
                tbdfpvalue.Text = hash;
            }
            JWTTokenHeader jh = new JWTTokenHeader();
            jh.alg = "RS256";
            jh.typ = "JWT";

            string jhencoded = helper.Base64UrlEncode(JsonConvert.SerializeObject(jh).ToString());

            JWTpayload jp = new JWTpayload();
            jp.sda = hash;
            jp.url = "certificate file for the prashant";
            jp.keyidx = "2018-11";
            string jpencoded = helper.Base64UrlEncode(JsonConvert.SerializeObject(jp).ToString());

            var encodedString = jhencoded + "." + jpencoded;

            //var privateKey = new X509Certificate2("my-key.p12", "password", X509KeyStorageFlags.Exportable | X509KeyStorageFlags.MachineKeySet).PrivateKey as RSACryptoServiceProvider;
            RsaSecurityKey issuerSigningKey = null;
            using (RSA publicRsa = RSA.Create())
            {
                var publicKeyXml = File.ReadAllText(@"public-rsa-key.xml");
                publicRsa.FromXmlString(publicKeyXml);
                issuerSigningKey = new RsaSecurityKey(publicRsa);
            }
            SigningCredentials signingCredentials = null;
            using (RSA privateRsa = RSA.Create())
            {
                var privateKeyXml = File.ReadAllText(@"private-rsa-key.xml");
                privateRsa.FromXmlString(privateKeyXml);
                var privateKey = new RsaSecurityKey(privateRsa);
                //signingCredentials = new SigningCredentials(privateKey, SecurityAlgorithms.RsaSha256Signature,SecurityAlgorithms.Sha256Digest);
                signingCredentials = new SigningCredentials(privateKey, SecurityAlgorithms.RsaSha256);

                byte[] byteData = Encoding.Unicode.GetBytes(encodedString);

                sign = Convert.ToBase64String(privateRsa.SignData(byteData, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1));
                tbdsvalue.Text = sign;
            }
            
        }

        public class JWTTokenHeader
        {
            public string alg;
            public string typ;

        }
        public class JWTpayload
        {
            public string sda;
            public string url;
            public string keyidx;
        }

        public class BCRequest
        {
            public string DigitalFingerPrint;
            public string Signature;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BCRequest bCRequest = new BCRequest
            {
                DigitalFingerPrint = tbdfpvalue.Text,
                Signature = tbdsvalue.Text
            };
            HttpClient httpClient = new HttpClient();
            string url = "https://prod-41.northeurope.logic.azure.com:443/workflows/0aa7f15d853a44ea863b707d826fa510/triggers/manual/paths/invoke?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=4xfegnMRnxPCZl1fw8LHbw_IQierRJX70LVkqrwAqpY";
            var httpContent = new StringContent(JsonConvert.SerializeObject(bCRequest).ToString(), Encoding.UTF8, "application/json");
            HttpResponseMessage response = httpClient.PostAsync(url, httpContent).Result;
            response.EnsureSuccessStatusCode();
            label3.Text = "Successfuly created transaction in blockchain!";
            lbhash.Text = "Transaction hash: ";
            lbthvalue.Text = response.Content.ReadAsStringAsync().Result;
        }
    }
}

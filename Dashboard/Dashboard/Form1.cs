using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows;
using System.Security.Cryptography;
using System.Threading;


namespace Dashboard
{
    public partial class Form1 : Form
    {
        // client configuration
        const string clientID = "581786658708-elflankerquo1a6vsckabbhn25hclla0.apps.googleusercontent.com";
        const string clientSecret = "3f6NggMbPtrmIBpgx-MK2xXK";
        const string authorizationEndpoint = "https://accounts.google.com/o/oauth2/v2/auth";
        const string tokenEndpoint = "https://www.googleapis.com/oauth2/v4/token";
        const string userInfoEndpoint = "https://www.googleapis.com/oauth2/v3/userinfo";

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
               int nLeftRect,
               int nTopRect,
               int nRightRect,
               int nBottomRect,
               int nWidthEllipse,
               int nHeightEllipse

         );

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNavigation.Height = btnHome.Height;
            pnlNavigation.Top = btnHome.Top;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlNavigation.Height = btnHome.Height;
            pnlNavigation.Top = btnHome.Top;
            btnHome.BackColor = Color.FromArgb(24, 34, 40);
            btnTransaction.BackColor = Color.FromArgb(36, 49, 58);
            pnl_Home.Visible = true;
            pnl_Transaction.Visible = false;
            pnl_Statistic.Visible = false;
            pnl_newTransaction.Visible = false;
            pnl_Settings.Visible = false;
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            pnlNavigation.Height = btnTransaction.Height;
            pnlNavigation.Top = btnTransaction.Top;
            btnTransaction.BackColor = Color.FromArgb(24, 34, 40);
            pnl_Home.Visible = false;
            pnl_Transaction.Visible = true;
            pnl_Statistic.Visible = false;
            pnl_newTransaction.Visible = false;
            pnl_Settings.Visible = false;
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            pnlNavigation.Height = btnStatistic.Height;
            pnlNavigation.Top = btnStatistic.Top;
            btnStatistic.BackColor = Color.FromArgb(24, 34, 40);
            btnTransaction.BackColor = Color.FromArgb(36, 49, 58);
            pnl_Home.Visible = false;
            pnl_Transaction.Visible = false;
            pnl_Statistic.Visible = true;
            pnl_newTransaction.Visible = false;
            pnl_Settings.Visible = false;
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            pnlNavigation.Height = btnsettings.Height;
            pnlNavigation.Top = btnsettings.Top;
            btnsettings.BackColor = Color.FromArgb(24, 34, 40);
            btnTransaction.BackColor = Color.FromArgb(36, 49, 58);
            pnl_Home.Visible = false;
            pnl_Transaction.Visible = false;
            pnl_Statistic.Visible = false;
            pnl_newTransaction.Visible = false;
            pnl_Settings.Visible = true;
        }

        private void btnHome_Leave(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(36, 49, 58);
        }

        private void btnTransaction_Leave(object sender, EventArgs e)
        {
            btnTransaction.BackColor = Color.FromArgb(36, 49, 58);
        }

        private void btnStatistic_Leave(object sender, EventArgs e)
        {
            btnStatistic.BackColor = Color.FromArgb(36, 49, 58);
        }

        private void btnsettings_Leave(object sender, EventArgs e)
        {
            btnsettings.BackColor = Color.FromArgb(36, 49, 58);
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tBx_TTdetail_Enter(object sender, EventArgs e)
        {
            if (tBx_TTdetail.Text == "Transaction Type")
            {
                tBx_TTdetail.Text = "";
                tBx_TTdetail.ForeColor = Color.White;
            }
        }

        private void tBx_TTdetail_Leave(object sender, EventArgs e)
        {
            if (tBx_TTdetail.Text == "")
            {
                tBx_TTdetail.Text = "Transaction Type";
                tBx_TTdetail.ForeColor = Color.Silver;
            }
        }

        private void btn_deleteTransaksi_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string judul = "Hapus Transaksi?";
            string pesan = "Transaksi yang dihapus tidak dapat diperoleh kembali";
            MessageBoxButtons pil_tombol = MessageBoxButtons.YesNo;

            result = MessageBox.Show(pesan, judul, pil_tombol, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Show();
            }

            else
            {
                this.Show();
            }
        }

        private void btn_CloudTransaksi_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string judul = "Upload ke Cloud?";
            string pesan = "Semua transaksi akan diupload dan disimpan di cloud storage";
            MessageBoxButtons pil_tombol = MessageBoxButtons.YesNo;

            result = MessageBox.Show(pesan, judul, pil_tombol, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                this.Show();
            }

            else
            {
                this.Show();
            }
        }

        private void tBx_dateDetail_Enter(object sender, EventArgs e)
        {
            if (tBx_DateDetail.Text == "Date")
            {
                tBx_DateDetail.Text = "";
                tBx_DateDetail.ForeColor = Color.White;
            }
        }

        private void tBx_dateDetail_Leave(object sender, EventArgs e)
        {
            if (tBx_DateDetail.Text == "")
            {
                tBx_DateDetail.Text = "Date";
                tBx_DateDetail.ForeColor = Color.Silver;
            }
        }

        private void btn_editTransaksi_Click(object sender, EventArgs e)
        {
            pnl_Home.Visible = false;
            pnl_Transaction.Visible = false;
            pnl_Settings.Visible = false;
            pnl_Statistic.Visible = false;
            pnl_newTransaction.Visible = true;
            lbl_JudulDetailTransaksi.Text = "Edit Transaction";
        }

        private void btn_NoDetail_Click(object sender, EventArgs e)
        {
            pnl_Home.Visible = false;
            pnl_Transaction.Visible = true;
            pnl_Settings.Visible = false;
            pnl_Statistic.Visible = false;
            pnl_newTransaction.Visible = false;
        }

        private void btn_addTransactionHome_Click(object sender, EventArgs e)
        {
            pnl_Home.Visible = false;
            pnl_Transaction.Visible = false;
            pnl_Settings.Visible = false;
            pnl_Statistic.Visible = false;
            pnl_newTransaction.Visible = true;
            lbl_JudulDetailTransaksi.Text = "Add Transaction";
            btnHome.BackColor = Color.FromArgb(36, 49, 58);
            btnTransaction.BackColor = Color.FromArgb(24, 34, 40);
            pnlNavigation.Height = btnTransaction.Height;
            pnlNavigation.Top = btnTransaction.Top;
        }

        private void btn_NoSettings_Click(object sender, EventArgs e)
        {
            pnlNavigation.Height = btnHome.Height;
            pnlNavigation.Top = btnHome.Top;
            btnHome.BackColor = Color.FromArgb(24, 34, 40);
            btnTransaction.BackColor = Color.FromArgb(36, 49, 58);
            pnl_Home.Visible = true;
            pnl_Transaction.Visible = false;
            pnl_Settings.Visible = false;
            pnl_Statistic.Visible = false;
            pnl_newTransaction.Visible = false;
        }

        private void tBx_displayNameSettings_Enter(object sender, EventArgs e)
        {
            if (tBx_DisplayNameSettings.Text == "Display Name")
            {
                tBx_DisplayNameSettings.Text = "";
                tBx_DisplayNameSettings.ForeColor = Color.White;
            }
        }

        private void tBx_displayNameSettings_Leave(object sender, EventArgs e)
        {

        }

        private void btn_YesDetail_Click(object sender, EventArgs e)
        {
            pnl_Home.Visible = false;
            pnl_Transaction.Visible = true;
            pnl_Settings.Visible = false;
            pnl_Statistic.Visible = false;
            pnl_newTransaction.Visible = false;
        }

        private void btn_EksporTransaksi_Click(object sender, EventArgs e)
        {

            string message = "Pilih media ekspor yang diinginkan";
            string title = "Ekspor Transaksi";
            MessageBoxButtons buttons = MessageBoxButtons.AbortRetryIgnore;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
            if (result == DialogResult.Abort)
            {
                this.Close();
            }
            else if (result == DialogResult.Retry)
            {
                // Do nothing  
            }

            else
            {
                // Do something  
            }
        }

        private async void btn_Login_Click(object sender, EventArgs e)
        {
            // Generates state and PKCE values.
            string state = randomDataBase64url(32);
            string code_verifier = randomDataBase64url(32);
            string code_challenge = base64urlencodeNoPadding(sha256(code_verifier));
            const string code_challenge_method = "S256";

            // Creates a redirect URI using an available port on the loopback address.
            string redirectURI = string.Format("http://{0}:{1}/", IPAddress.Loopback, GetRandomUnusedPort());
            output("redirect URI: " + redirectURI);

            // Creates an HttpListener to listen for requests on that redirect URI.
            var http = new HttpListener();
            http.Prefixes.Add(redirectURI);
            output("Listening..");
            http.Start();

            // Creates the OAuth 2.0 authorization request.
            string authorizationRequest = string.Format("{0}?response_type=code&scope=openid%20profile&redirect_uri={1}&client_id={2}&state={3}&code_challenge={4}&code_challenge_method={5}",
                authorizationEndpoint,
                System.Uri.EscapeDataString(redirectURI),
                clientID,
                state,
                code_challenge,
                code_challenge_method);

            // Opens request in the browser.
            System.Diagnostics.Process.Start(authorizationRequest);

            // Waits for the OAuth authorization response.
            var context = await http.GetContextAsync();

            // Brings this app back to the foreground.
            this.Activate();

            // Sends an HTTP response to the browser.
            var response = context.Response;
            string responseString = string.Format("<html><head><meta http-equiv='refresh' content='10;url=https://google.com'></head><body>Please return to the app.</body></html>");
            var buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
            response.ContentLength64 = buffer.Length;
            var responseOutput = response.OutputStream;
            Task responseTask = responseOutput.WriteAsync(buffer, 0, buffer.Length).ContinueWith((task) =>
            {
                responseOutput.Close();
                http.Stop();
                Console.WriteLine("HTTP server stopped.");
            });

            // Checks for errors.
            if (context.Request.QueryString.Get("error") != null)
            {
                output(String.Format("OAuth authorization error: {0}.", context.Request.QueryString.Get("error")));
                return;
            }
            if (context.Request.QueryString.Get("code") == null
                || context.Request.QueryString.Get("state") == null)
            {
                output("Malformed authorization response. " + context.Request.QueryString);
                return;
            }

            // extracts the code
            var code = context.Request.QueryString.Get("code");
            var incoming_state = context.Request.QueryString.Get("state");

            // Compares the receieved state to the expected value, to ensure that
            // this app made the request which resulted in authorization.
            if (incoming_state != state)
            {
                output(String.Format("Received request with invalid state ({0})", incoming_state));
                return;
            }
            output("Authorization code: " + code);

            // Starts the code exchange at the Token Endpoint.
            performCodeExchange(code, code_verifier, redirectURI);
        }

        async void performCodeExchange(string code, string code_verifier, string redirectURI)
        {
            output("Exchanging code for tokens...");

            // builds the  request
            string tokenRequestURI = "https://www.googleapis.com/oauth2/v4/token";
            string tokenRequestBody = string.Format("code={0}&redirect_uri={1}&client_id={2}&code_verifier={3}&client_secret={4}&scope=&grant_type=authorization_code",
                code,
                System.Uri.EscapeDataString(redirectURI),
                clientID,
                code_verifier,
                clientSecret
                );

            // sends the request
            HttpWebRequest tokenRequest = (HttpWebRequest)WebRequest.Create(tokenRequestURI);
            tokenRequest.Method = "POST";
            tokenRequest.ContentType = "application/x-www-form-urlencoded";
            tokenRequest.Accept = "Accept=text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            byte[] _byteVersion = Encoding.ASCII.GetBytes(tokenRequestBody);
            tokenRequest.ContentLength = _byteVersion.Length;
            Stream stream = tokenRequest.GetRequestStream();
            await stream.WriteAsync(_byteVersion, 0, _byteVersion.Length);
            stream.Close();

            try
            {
                // gets the response
                WebResponse tokenResponse = await tokenRequest.GetResponseAsync();
                using (StreamReader reader = new StreamReader(tokenResponse.GetResponseStream()))
                {
                    // reads response body
                    string responseText = await reader.ReadToEndAsync();
                    output(responseText);

                    // converts to dictionary
                    Dictionary<string, string> tokenEndpointDecoded = JsonConvert.DeserializeObject<Dictionary<string, string>>(responseText);

                    string access_token = tokenEndpointDecoded["access_token"];
                    userinfoCall(access_token);
                }
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    var response = ex.Response as HttpWebResponse;
                    if (response != null)
                    {
                        output("HTTP: " + response.StatusCode);
                        using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                        {
                            // reads response body
                            string responseText = await reader.ReadToEndAsync();
                            output(responseText);
                        }
                    }

                }
            }
        }

        public string GetUrl(string bitlyResponse)
        {
            var responseObject = new
            {
                data = new { url = string.Empty },
            };

            responseObject = JsonConvert.DeserializeAnonymousType(bitlyResponse, responseObject);
            return responseObject.data.url;
        }

        async void userinfoCall(string access_token)
        {
            output("Making API Call to Userinfo...");

            // builds the  request
            string userinfoRequestURI = "https://www.googleapis.com/oauth2/v3/userinfo";

            // sends the request
            HttpWebRequest userinfoRequest = (HttpWebRequest)WebRequest.Create(userinfoRequestURI);
            userinfoRequest.Method = "GET";
            userinfoRequest.Headers.Add(string.Format("Authorization: Bearer {0}", access_token));
            userinfoRequest.ContentType = "application/x-www-form-urlencoded";
            userinfoRequest.Accept = "Accept=text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";

            // gets the response
            WebResponse userinfoResponse = await userinfoRequest.GetResponseAsync();
            using (StreamReader userinfoResponseReader = new StreamReader(userinfoResponse.GetResponseStream()))
            {
                // reads response body
                string userinfoResponseText = await userinfoResponseReader.ReadToEndAsync();
                Account account = JsonConvert.DeserializeObject<Account>(userinfoResponseText);

                tBx_DisplayNameSettings.Text = account.name;
                pictureBox1.Load(account.picture);
                pictureBox5.Load(account.picture);
                //output(userinfoResponseText);
                pnl_SplashScreen.Visible = false;
                pnl_Login.Visible = false;
                pnl_SideBar.Visible = true;
                pnl_Home.Visible = true;
                pnl_Transaction.Visible = false;
                pnl_Statistic.Visible = false;
                pnl_newTransaction.Visible = false;
                pnl_Settings.Visible = false;
            }
        }

        /// <summary>
        /// Appends the given string to the on-screen log, and the debug console.
        /// </summary>
        /// <param name="output">string to be appended</param>
        public void output(string output)
        {
            //.Text = output + Environment.NewLine;
            Console.WriteLine(output);
        }



        /// <summary>
        /// Returns URI-safe data with a given input length.
        /// </summary>
        /// <param name="length">Input length (nb. output will be longer)</param>
        /// <returns></returns>
        public static string randomDataBase64url(uint length)
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] bytes = new byte[length];
            rng.GetBytes(bytes);
            return base64urlencodeNoPadding(bytes);
        }

        /// <summary>
        /// Returns the SHA256 hash of the input string.
        /// </summary>
        /// <param name="inputStirng"></param>
        /// <returns></returns>
        public static byte[] sha256(string inputStirng)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(inputStirng);
            SHA256Managed sha256 = new SHA256Managed();
            return sha256.ComputeHash(bytes);
        }

        /// <summary>
        /// Base64url no-padding encodes the given input buffer.
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public static string base64urlencodeNoPadding(byte[] buffer)
        {
            string base64 = Convert.ToBase64String(buffer);

            // Converts base64 to base64url.
            base64 = base64.Replace("+", "-");
            base64 = base64.Replace("/", "_");
            // Strips padding.
            base64 = base64.Replace("=", "");

            return base64;
        }

        public static int GetRandomUnusedPort()
        {
            var listener = new TcpListener(IPAddress.Loopback, 0);
            listener.Start();
            var port = ((IPEndPoint)listener.LocalEndpoint).Port;
            listener.Stop();
            return port;
        }
        private void btn_LogoutSettings_Click(object sender, EventArgs e)
        {
            pnl_SplashScreen.Visible = false;
            pnl_Login.Visible = true;
            pnl_SideBar.Visible = false;
            pnl_Home.Visible = false;
            pnl_Transaction.Visible = false;
            pnl_Statistic.Visible = false;
            pnl_newTransaction.Visible = false;
            pnl_Settings.Visible = false;
        }

        private void timer_SplashScreen_Tick(object sender, EventArgs e)
        {
            timer_SplashScreen.Enabled = true;
            progressBar1.Increment(5);
            progressBar1.Visible = false;

            if (progressBar1.Value == 100)
            {
                timer_SplashScreen.Enabled = false;

                pnl_SplashScreen.Visible = false;
                pnl_Login.Visible = true;
                pnl_SideBar.Visible = false;
                pnl_Home.Visible = false;
                pnl_Transaction.Visible = false;
                pnl_Statistic.Visible = false;
                pnl_newTransaction.Visible = false;
                pnl_Settings.Visible = false;
            }
        }
    }
}

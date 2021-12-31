using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Net;
using System.Runtime.Serialization;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace KeyAuth
{
	// Token: 0x02000002 RID: 2
	public class api
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public api(string name, string ownerid, string secret, string version)
		{
			bool flag = string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(ownerid) || string.IsNullOrWhiteSpace(secret) || string.IsNullOrWhiteSpace(version);
			if (flag)
			{
				MessageBox.Show("Application not setup correctly. Please watch video link found in Login.cs");
				Environment.Exit(0);
			}
			this.name = name;
			this.ownerid = ownerid;
			this.secret = secret;
			this.version = version;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000020D8 File Offset: 0x000002D8
		public void init()
		{
			this.enckey = encryption.sha256(encryption.iv_key());
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("init"));
			nameValueCollection["ver"] = encryption.encrypt(this.version, this.secret, text);
			nameValueCollection["enckey"] = encryption.encrypt(this.enckey, this.secret, text);
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			bool flag = text2 == "KeyAuth_Invalid";
			if (flag)
			{
				MessageBox.Show("Application not found.");
				Environment.Exit(0);
			}
			text2 = encryption.decrypt(text2, this.secret, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			bool success = response_structure.success;
			if (success)
			{
				this.sessionid = response_structure.sessionid;
				this.initzalized = true;
			}
			else
			{
				bool flag2 = response_structure.message == "invalidver";
				if (flag2)
				{
					Process.Start(response_structure.download);
					Environment.Exit(0);
				}
				else
				{
					MessageBox.Show(response_structure.message);
					Environment.Exit(0);
				}
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002260 File Offset: 0x00000460
		public bool register(string username, string pass, string key)
		{
			bool flag = !this.initzalized;
			bool result;
			if (flag)
			{
				MessageBox.Show("Please initzalize first");
				result = false;
			}
			else
			{
				string value = WindowsIdentity.GetCurrent().User.Value;
				string text = encryption.sha256(encryption.iv_key());
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("register"));
				nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
				nameValueCollection["pass"] = encryption.encrypt(pass, this.enckey, text);
				nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
				nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
				nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
				nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
				nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
				nameValueCollection["init_iv"] = text;
				NameValueCollection post_data = nameValueCollection;
				string text2 = api.req(post_data);
				text2 = encryption.decrypt(text2, this.enckey, text);
				api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
				bool flag2 = !response_structure.success;
				if (flag2)
				{
					MessageBox.Show(response_structure.message);
					result = false;
				}
				else
				{
					this.load_user_data(response_structure.info);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002404 File Offset: 0x00000604
		public bool login(string username, string pass)
		{
			bool flag = !this.initzalized;
			bool result;
			if (flag)
			{
				MessageBox.Show("Please initzalize first");
				result = false;
			}
			else
			{
				string value = WindowsIdentity.GetCurrent().User.Value;
				string text = encryption.sha256(encryption.iv_key());
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("login"));
				nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
				nameValueCollection["pass"] = encryption.encrypt(pass, this.enckey, text);
				nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
				nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
				nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
				nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
				nameValueCollection["init_iv"] = text;
				NameValueCollection post_data = nameValueCollection;
				string text2 = api.req(post_data);
				text2 = encryption.decrypt(text2, this.enckey, text);
				api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
				bool flag2 = !response_structure.success;
				if (flag2)
				{
					MessageBox.Show(response_structure.message);
					result = false;
				}
				else
				{
					this.load_user_data(response_structure.info);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002590 File Offset: 0x00000790
		public void upgrade(string username, string key)
		{
			bool flag = !this.initzalized;
			if (flag)
			{
				MessageBox.Show("Please initzalize first");
			}
			else
			{
				string value = WindowsIdentity.GetCurrent().User.Value;
				string text = encryption.sha256(encryption.iv_key());
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("upgrade"));
				nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
				nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
				nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
				nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
				nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
				nameValueCollection["init_iv"] = text;
				NameValueCollection post_data = nameValueCollection;
				string text2 = api.req(post_data);
				text2 = encryption.decrypt(text2, this.enckey, text);
				api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
				bool flag2 = !response_structure.success;
				if (flag2)
				{
					MessageBox.Show(response_structure.message);
					Environment.Exit(0);
				}
				else
				{
					MessageBox.Show(response_structure.message);
				}
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000026FC File Offset: 0x000008FC
		public bool license(string key)
		{
			bool flag = !this.initzalized;
			bool result;
			if (flag)
			{
				MessageBox.Show("Please initzalize first");
				result = false;
			}
			else
			{
				string value = WindowsIdentity.GetCurrent().User.Value;
				string text = encryption.sha256(encryption.iv_key());
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("license"));
				nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
				nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
				nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
				nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
				nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
				nameValueCollection["init_iv"] = text;
				NameValueCollection post_data = nameValueCollection;
				string text2 = api.req(post_data);
				text2 = encryption.decrypt(text2, this.enckey, text);
				api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
				bool flag2 = !response_structure.success;
				if (flag2)
				{
					MessageBox.Show(response_structure.message);
					Environment.Exit(0);
					result = false;
				}
				else
				{
					this.load_user_data(response_structure.info);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002874 File Offset: 0x00000A74
		public void ban()
		{
			bool flag = !this.initzalized;
			if (flag)
			{
				MessageBox.Show("Please initzalize first");
			}
			else
			{
				string text = encryption.sha256(encryption.iv_key());
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("ban"));
				nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
				nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
				nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
				nameValueCollection["init_iv"] = text;
				NameValueCollection post_data = nameValueCollection;
				string text2 = api.req(post_data);
				text2 = encryption.decrypt(text2, this.enckey, text);
				api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
				bool flag2 = !response_structure.success;
				if (flag2)
				{
					MessageBox.Show(response_structure.message);
					Environment.Exit(0);
				}
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002990 File Offset: 0x00000B90
		public string var(string varid)
		{
			bool flag = !this.initzalized;
			string result;
			if (flag)
			{
				MessageBox.Show("Please initzalize first");
				result = "";
			}
			else
			{
				string value = WindowsIdentity.GetCurrent().User.Value;
				string text = encryption.sha256(encryption.iv_key());
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("var"));
				nameValueCollection["varid"] = encryption.encrypt(varid, this.enckey, text);
				nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
				nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
				nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
				nameValueCollection["init_iv"] = text;
				NameValueCollection post_data = nameValueCollection;
				string text2 = api.req(post_data);
				text2 = encryption.decrypt(text2, this.enckey, text);
				api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
				bool flag2 = !response_structure.success;
				if (flag2)
				{
					MessageBox.Show(response_structure.message);
					result = "";
				}
				else
				{
					result = response_structure.message;
				}
			}
			return result;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002AE8 File Offset: 0x00000CE8
		public void webhook(string webid, string param)
		{
			bool flag = !this.initzalized;
			if (flag)
			{
				MessageBox.Show("Please initzalize first");
			}
			else
			{
				string value = WindowsIdentity.GetCurrent().User.Value;
				string text = encryption.sha256(encryption.iv_key());
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("webhook"));
				nameValueCollection["webid"] = encryption.encrypt(webid, this.enckey, text);
				nameValueCollection["params"] = encryption.encrypt(param, this.enckey, text);
				nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
				nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
				nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
				nameValueCollection["init_iv"] = text;
				NameValueCollection post_data = nameValueCollection;
				string text2 = api.req(post_data);
				text2 = encryption.decrypt(text2, this.enckey, text);
				api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
				bool flag2 = !response_structure.success;
				if (flag2)
				{
					MessageBox.Show(response_structure.message);
				}
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002C40 File Offset: 0x00000E40
		public byte[] download(string fileid)
		{
			bool flag = !this.initzalized;
			byte[] result;
			if (flag)
			{
				MessageBox.Show("Please initzalize first");
				result = new byte[0];
			}
			else
			{
				string text = encryption.sha256(encryption.iv_key());
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("file"));
				nameValueCollection["fileid"] = encryption.encrypt(fileid, this.enckey, text);
				nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
				nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
				nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
				nameValueCollection["init_iv"] = text;
				NameValueCollection post_data = nameValueCollection;
				string text2 = api.req(post_data);
				text2 = encryption.decrypt(text2, this.enckey, text);
				api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
				bool flag2 = !response_structure.success;
				if (flag2)
				{
					MessageBox.Show(response_structure.message);
				}
				result = encryption.str_to_byte_arr(response_structure.contents);
			}
			return result;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002D84 File Offset: 0x00000F84
		public void log(string message)
		{
			bool flag = !this.initzalized;
			if (flag)
			{
				MessageBox.Show("Please initzalize first");
			}
			else
			{
				string text = encryption.sha256(encryption.iv_key());
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("log"));
				nameValueCollection["pcuser"] = encryption.encrypt(Environment.UserName, this.enckey, text);
				nameValueCollection["message"] = encryption.encrypt(message, this.enckey, text);
				nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
				nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
				nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
				nameValueCollection["init_iv"] = text;
				NameValueCollection post_data = nameValueCollection;
				api.req(post_data);
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002E90 File Offset: 0x00001090
		private static string req(NameValueCollection post_data)
		{
			string result;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					byte[] bytes = webClient.UploadValues("https://keyauth.uk/api/1.0/", post_data);
					result = Encoding.Default.GetString(bytes);
				}
			}
			catch (WebException ex)
			{
				HttpWebResponse httpWebResponse = (HttpWebResponse)ex.Response;
				HttpStatusCode statusCode = httpWebResponse.StatusCode;
				HttpStatusCode httpStatusCode = statusCode;
				if (httpStatusCode != (HttpStatusCode)429)
				{
					Console.WriteLine("\n\n  Connection failure. Please try again, or contact us for help.");
					Thread.Sleep(3500);
					Environment.Exit(0);
					result = "";
				}
				else
				{
					Console.WriteLine("\n\n  You're connecting too fast to loader, slow down.");
					Thread.Sleep(3500);
					Environment.Exit(0);
					result = "";
				}
			}
			return result;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002F5C File Offset: 0x0000115C
		private void load_user_data(api.user_data_structure data)
		{
			this.user_data.username = data.username;
			this.user_data.ip = data.ip;
			this.user_data.subscriptions = data.subscriptions;
		}

		// Token: 0x04000001 RID: 1
		public string name;

		// Token: 0x04000002 RID: 2
		public string ownerid;

		// Token: 0x04000003 RID: 3
		public string secret;

		// Token: 0x04000004 RID: 4
		public string version;

		// Token: 0x04000005 RID: 5
		private string sessionid;

		// Token: 0x04000006 RID: 6
		private string enckey;

		// Token: 0x04000007 RID: 7
		private bool initzalized;

		// Token: 0x04000008 RID: 8
		public api.user_data_class user_data = new api.user_data_class();

		// Token: 0x04000009 RID: 9
		private json_wrapper response_decoder = new json_wrapper(new api.response_structure());

		// Token: 0x0200000D RID: 13
		[DataContract]
		private class response_structure
		{
			// Token: 0x17000005 RID: 5
			// (get) Token: 0x06000049 RID: 73 RVA: 0x0000671E File Offset: 0x0000491E
			// (set) Token: 0x0600004A RID: 74 RVA: 0x00006726 File Offset: 0x00004926
			[DataMember]
			public bool success { get; set; }

			// Token: 0x17000006 RID: 6
			// (get) Token: 0x0600004B RID: 75 RVA: 0x0000672F File Offset: 0x0000492F
			// (set) Token: 0x0600004C RID: 76 RVA: 0x00006737 File Offset: 0x00004937
			[DataMember]
			public string sessionid { get; set; }

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x0600004D RID: 77 RVA: 0x00006740 File Offset: 0x00004940
			// (set) Token: 0x0600004E RID: 78 RVA: 0x00006748 File Offset: 0x00004948
			[DataMember]
			public string contents { get; set; }

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x0600004F RID: 79 RVA: 0x00006751 File Offset: 0x00004951
			// (set) Token: 0x06000050 RID: 80 RVA: 0x00006759 File Offset: 0x00004959
			[DataMember]
			public string response { get; set; }

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x06000051 RID: 81 RVA: 0x00006762 File Offset: 0x00004962
			// (set) Token: 0x06000052 RID: 82 RVA: 0x0000676A File Offset: 0x0000496A
			[DataMember]
			public string message { get; set; }

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x06000053 RID: 83 RVA: 0x00006773 File Offset: 0x00004973
			// (set) Token: 0x06000054 RID: 84 RVA: 0x0000677B File Offset: 0x0000497B
			[DataMember]
			public string download { get; set; }

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x06000055 RID: 85 RVA: 0x00006784 File Offset: 0x00004984
			// (set) Token: 0x06000056 RID: 86 RVA: 0x0000678C File Offset: 0x0000498C
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.user_data_structure info { get; set; }
		}

		// Token: 0x0200000E RID: 14
		[DataContract]
		private class user_data_structure
		{
			// Token: 0x1700000C RID: 12
			// (get) Token: 0x06000058 RID: 88 RVA: 0x0000679E File Offset: 0x0000499E
			// (set) Token: 0x06000059 RID: 89 RVA: 0x000067A6 File Offset: 0x000049A6
			[DataMember]
			public string username { get; set; }

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x0600005A RID: 90 RVA: 0x000067AF File Offset: 0x000049AF
			// (set) Token: 0x0600005B RID: 91 RVA: 0x000067B7 File Offset: 0x000049B7
			[DataMember]
			public List<api.Data> subscriptions { get; set; }

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x0600005C RID: 92 RVA: 0x000067C0 File Offset: 0x000049C0
			// (set) Token: 0x0600005D RID: 93 RVA: 0x000067C8 File Offset: 0x000049C8
			[DataMember]
			public string ip { get; set; }
		}

		// Token: 0x0200000F RID: 15
		public class user_data_class
		{
			// Token: 0x1700000F RID: 15
			// (get) Token: 0x0600005F RID: 95 RVA: 0x000067DA File Offset: 0x000049DA
			// (set) Token: 0x06000060 RID: 96 RVA: 0x000067E2 File Offset: 0x000049E2
			public string username { get; set; }

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x06000061 RID: 97 RVA: 0x000067EB File Offset: 0x000049EB
			// (set) Token: 0x06000062 RID: 98 RVA: 0x000067F3 File Offset: 0x000049F3
			public List<api.Data> subscriptions { get; set; }

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x06000063 RID: 99 RVA: 0x000067FC File Offset: 0x000049FC
			// (set) Token: 0x06000064 RID: 100 RVA: 0x00006804 File Offset: 0x00004A04
			public string ip { get; set; }
		}

		// Token: 0x02000010 RID: 16
		public class Data
		{
			// Token: 0x17000012 RID: 18
			// (get) Token: 0x06000066 RID: 102 RVA: 0x00006816 File Offset: 0x00004A16
			// (set) Token: 0x06000067 RID: 103 RVA: 0x0000681E File Offset: 0x00004A1E
			public string subscription { get; set; }

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x06000068 RID: 104 RVA: 0x00006827 File Offset: 0x00004A27
			// (set) Token: 0x06000069 RID: 105 RVA: 0x0000682F File Offset: 0x00004A2F
			public string expiry { get; set; }
		}
	}
}

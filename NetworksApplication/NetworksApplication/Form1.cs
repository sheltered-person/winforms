using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Diagnostics.Tracing;

namespace NetworksApplication
{
    public partial class NForm : System.Windows.Forms.Form
    {
        private NetworkInterface[] nics;
        private ToolStripItem[] items;
        private List<UnicastInfo> unicasts;
        private List<MulticastInfo> multicasts;
        private List<DNSInfo> dns;

        private int i = 0;

        public NForm()
        {
            InitializeComponent();
        }

        private void NForm_Load(object sender, EventArgs e)
        {
            nics = NetworkInterface.GetAllNetworkInterfaces();
            items = new ToolStripItem[nics.Length];
            unicasts = new List<UnicastInfo>();
            multicasts = new List<MulticastInfo>();
            dns = new List<DNSInfo>();

            for (int i = 0; i < nics.Length; i++)
                items[i] = new ToolStripMenuItem(nics[i].Description);

            toolStripMenuItem.DropDownItems.AddRange(items);
            LoadInterfaceInfo();
        }

        private void LoadInterfaceInfo()
        {
            if (nics.Length == 0)
            {
                MessageBox.Show("Can't find any network interfaces! Sorry...");
                return;
            }    

            nameLabel.Text = nics[i].Name;
            descrLabel.Text = nics[i].Description;
            guidLabel.Text = nics[i].Id;
            typeLabel.Text = nics[i].NetworkInterfaceType.ToString();
            macLabel.Text = nics[i].GetPhysicalAddress().ToString();
            statusLabel.Text = nics[i].OperationalStatus.ToString();

            long speed = nics[i].Speed;

            if (speed == -1)
                speedLabel.Text = "None";
            else
                speedLabel.Text = speed.ToString();

            ipVersionLabel.Text = "";

            if (nics[i].Supports(NetworkInterfaceComponent.IPv4))
            {
                ipVersionLabel.Text = "IPv4";
            }
            if (nics[i].Supports(NetworkInterfaceComponent.IPv6))
            {
                if (ipVersionLabel.Text.Length > 0)
                {
                    ipVersionLabel.Text += ",  ";
                }
                ipVersionLabel.Text += "IPv6";
            }

            LoadInterfaceUnicasts();
            unicastGridView.DataSource = unicasts;
            unicastGridView.DefaultCellStyle.SelectionBackColor = Color.White;
            unicastGridView.DefaultCellStyle.SelectionForeColor = Color.Black;
            unicastGridView.Columns[0].Width = 220;
            unicastGridView.ClearSelection();

            LoadInterfaceMulticasts();
            multicastGridView.DataSource = multicasts;
            multicastGridView.Columns[0].Width = 155;
            multicastGridView.DefaultCellStyle.SelectionBackColor = Color.White;
            multicastGridView.DefaultCellStyle.SelectionForeColor = Color.Black;
            multicastGridView.ClearSelection();

            LoadInterfaceDns();
            dnsGridView.DataSource = dns;
            dnsGridView.Columns[0].Width = 155;
            dnsGridView.DefaultCellStyle.SelectionBackColor = Color.White;
            dnsGridView.DefaultCellStyle.SelectionForeColor = Color.Black;
            dnsGridView.ClearSelection();
        }

        private void LoadInterfaceUnicasts()
        {
            unicasts = new List<UnicastInfo>();

            IPInterfaceProperties properties = nics[i].GetIPProperties();
            UnicastIPAddressInformationCollection uniCast = properties.UnicastAddresses;

            if (uniCast != null)
            {
                foreach (UnicastIPAddressInformation uni in uniCast)
                {
                    unicasts.Add(new UnicastInfo()
                    {
                        Address = uni.Address.ToString(),
                        Mask = uni.IPv4Mask.ToString(),
                        Prefix = uni.PrefixOrigin.ToString(),
                        Suffix = uni.SuffixOrigin.ToString()
                    });
                }
            }
        }

        private void LoadInterfaceMulticasts()
        {
            multicasts = new List<MulticastInfo>();

            IPInterfaceProperties properties = nics[i].GetIPProperties();
            MulticastIPAddressInformationCollection multiCast = properties.MulticastAddresses;

            if (multiCast != null)
            {
                foreach (var multi in multiCast)
                    multicasts.Add(new MulticastInfo() 
                    { 
                        Address = multi.Address.ToString() 
                    });
            }
        }

        private void LoadInterfaceDns()
        {
            dns = new List<DNSInfo>();

            IPInterfaceProperties properties = nics[i].GetIPProperties();
            IPAddressCollection dnsServers = properties.DnsAddresses;

            if (dnsServers != null)
            {
                foreach (var server in dnsServers)
                    dns.Add(new DNSInfo() 
                    { 
                        Address = server.ToString() 
                    });
            }
        }

        private void toolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            for (int j = 0; j < nics.Length; j++)
            {
                if (nics[j].Description == e.ClickedItem.Text)
                {
                    i = j;
                    break;
                }
            }

            LoadInterfaceInfo();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;



namespace TSOClient
{
    public partial class Form1 : Form
    {
        private int port = 12255;
        Connection connection = new Connection();
        private bool connectionEstablished = false;
        private bool connectionError = false;
        private FileInfo file;
        private string fileName;
        private string filePath;
        private long fileSize;
        private Thread connectionThread;
        private Thread connectionCheck;
        private volatile bool stopThreads = false;
        public Form1()
        {
            InitializeComponent();    
        }

        private void CheckConnection() {
            while (!connectionEstablished && !connectionError && !stopThreads)
            {
                connectionEstablished = connection.getStatus();
                connectionError = connection.getErrorCheck();
            }
            if (connectionError) wl("ERROR: " + connection.getError());
            if (connectionEstablished) ConnectionEstablished();
        }

        private void ConnectionEstablished()
        {
            btnListen.Enabled = true;
            btnConnect.Enabled = true;
        }

        private void txtDragDrop_DragEnter(object sender, DragEventArgs e)
        {
            // Check if the Dataformat of the data can be accepted
            // (we only accept file drops from Explorer, etc.)
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy; // Okay
            else
                e.Effect = DragDropEffects.None; // Unknown data, ignore it 
        }

        private void txtDragDrop_DragDrop(object sender, DragEventArgs e)
        {
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);         
            string[] fileSplit;
            StringBuilder pathSB = new StringBuilder();
            
            foreach (string File in FileList)
            {
                try
                {
                    file = new FileInfo(File);
                    fileSplit = File.Split('\\');
                    fileName = fileSplit[fileSplit.Length - 1];
                    for (int i = 0; i < fileSplit.Length - 1; i++)
                    {
                        pathSB.Append(fileSplit[i] + "\\");
                    }
                    filePath = pathSB.ToString();
                    fileSize = file.Length;
                    wl("File name: " + fileName);
                    wl("File size: " + fileSize);
                    wl("File path: " + filePath);
                }
                catch (FileNotFoundException ex)
                {
                    wl("File not found!");
                }
            }
        }

        private void wl(string str)
        {
            txtStatus.AppendText(str);
            txtStatus.AppendText(Environment.NewLine);
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            connection.setPort(port);
            connectionThread = new Thread(new ThreadStart(connection.Listen));
            connectionThread.Start();
            connectionCheck = new Thread(new ThreadStart(CheckConnection));
            connectionCheck.Start();
          //  btnListen.Enabled = false;
          //  btnConnect.Enabled = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

        }

        private void debug_Click(object sender, EventArgs e)
        {
            wl("connectionEstablished: " + connectionEstablished.ToString());
            wl("connectionError: " + connectionError.ToString());
            wl("errorMsg: " + connection.getError());
            wl("File name: " + fileName);
            wl("File size: " + fileSize);
            wl("File path: " + filePath);
            wl("connection.getStatus(): " + connection.getStatus());
            wl("connection.getError(): " + connection.getErrorCheck());
            wl("connection debug msg: " + connection.getStr());
            wl("");
        }



    }
}

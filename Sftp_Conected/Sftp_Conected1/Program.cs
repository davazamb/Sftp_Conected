using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tamir.SharpSsh;

namespace Sftp_Conected1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConectarSFTP();
        }

        private static void ConectarSFTP()
        {
            string Hostname = "ftp-server.demo.solarwinds.com";
            string dir_path = "demo";
            string Username = "demo";
            string Password = "demo";

            Sftp sftpClient = new Sftp(Hostname, Username, Password);

            try
            {
                Console.Write("Connecting...");
                sftpClient.Connect(21);
                if (sftpClient.Connected)
                {

                    Console.WriteLine("OK");
                }
                else
                {

                    Console.WriteLine("NO OK");
                }
            }
            catch (Exception EX)
            {

                throw;
            }
        }
    }
}

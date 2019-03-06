using Blackbox.Client.Prop;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Blackbox.Client.src
{
    public class SocketConn
    {
		public class SynchronousSocketClient {  
		  
		    public static void StartClient(string xmlText) {  
		        // Data buffer for incoming data.  
		        byte[] bytes = new byte[1024];  
		  
		        // Connect to a remote device.  
		        try {  
		            // Establish the remote endpoint for the socket.  
		            // This example uses port 11000 on the local computer.  
		            IPHostEntry ipHostInfo = Dns.GetHostEntry("127.0.0.1");  
		            IPAddress ipAddress = ipHostInfo.AddressList[0];  
		            IPEndPoint remoteEP = new IPEndPoint(ipAddress,11000);  
		  
		            // Create a TCP/IP  socket.  
		            Socket sender = new Socket(ipAddress.AddressFamily,   
		                SocketType.Stream, ProtocolType.Tcp );  
		  
		            // Connect the socket to the remote endpoint. Catch any errors.  
		            try {  
		                sender.Connect(remoteEP);

                        Console.WriteLine("Socket connected to {0}",
                            sender.RemoteEndPoint.ToString());
                        Console.WriteLine("XML text sent = {0}",
                            xmlText);

                        // Encode the data string into a byte array.  
                        //Encryption.Encrypt(xmlText, "Security1234");
                        byte[] msg = Encoding.ASCII.GetBytes(Encryption.Encrypt(xmlText, "Security1234") + "<EOF>");  
		  
		                // Send the data through the socket.  
		                int bytesSent = sender.Send(msg);
                        Console.WriteLine("Encrypted text sent = {0}",
                            Encoding.ASCII.GetString(msg, 0, bytesSent));
		  
		                // Receive the response from the remote device.  
		                int bytesRec = sender.Receive(bytes);  
		                Console.WriteLine("Encrypted text received = {0}",  
		                    Encoding.ASCII.GetString(bytes,0,bytesRec));
                        var content = Encoding.ASCII.GetString(bytes, 0, bytesRec);

                        var contentText = Encryption.Decrypt(content, "Security1234");
                        Console.WriteLine("Decrypted text received = {0}",
                            contentText);
                        // Here goes the action for the text received from server
                        Handle.ReadText(contentText);
                        //

                        // Release the socket.  
                        sender.Shutdown(SocketShutdown.Both);  
		                sender.Close();  
		  
		            } catch (ArgumentNullException ane) {  
		                Console.WriteLine("ArgumentNullException : {0}",ane.ToString());  
		            } catch (SocketException se) {  
		                Console.WriteLine("SocketException : {0}",se.ToString());  
		            } catch (Exception e) {  
		                Console.WriteLine("Unexpected exception : {0}", e.ToString());  
		            }  
		  
		        } catch (Exception e) {  
		            Console.WriteLine( e.ToString());  
		        }  
		    }  
		  
		    //public static int Main(String[] args) {  
		    //    StartClient();  
		    //    return 0;  
		    //}  
		}  
    }
}
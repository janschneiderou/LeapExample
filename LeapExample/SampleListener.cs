using Leap;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LeapExample
{
    class SampleListener
    {
        Program myProgram;
        System.DateTime startRecordingTime;
        FrameObject myFrameObject;
        List<string> names;
        Socket udpSendingSocket;
        IPEndPoint UDPendPoint;
        bool isRunning = true;
        int frameNumber = 0;

        public void OnServiceConnect(object sender, ConnectionEventArgs args)
        {
            Console.WriteLine("Service Connected");
        }

        public void OnConnect(object sender, DeviceEventArgs args)
        {
            Console.WriteLine("Connected");
            Program.myConnector.sendReady();
            //storevalues();
            //IPAddress serverAddr = IPAddress.Parse("127.0.0.1");
            //UDPendPoint = new IPEndPoint(serverAddr, 11004);
            //udpSendingSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram,
            //ProtocolType.Udp);
            //startRecordingTime = DateTime.Now;
            //frameNumber = 0;
        }

        public void OnFrame(object sender, FrameEventArgs args)
        {

            Console.WriteLine("Frame Available.");


            try
            {
                List<string> values = new List<string>();
                for (int i = 0; i < 120; i++)
                {
                    values.Add("NAN");
                }
                int count = 0;
                foreach (Hand h in args.frame.Hands)
                {
                    foreach (Finger f in h.Fingers)
                    {

                        foreach (Bone b in f.bones)
                        {
                            values[count] = b.NextJoint.x.ToString();
                            count++;
                            values[count] = b.NextJoint.y.ToString();
                            count++;
                            values[count] = b.NextJoint.z.ToString();
                            count++;
                        }
                    }
                }
                //// storevalues();
                //FrameObject fr = new FrameObject(startRecordingTime, names, values);
                //string json = JsonConvert.SerializeObject(fr, Formatting.Indented);
                //json = "FrameSENT:"+frameNumber + json;
                //frameNumber++;
                //byte[] send_buffer = Encoding.ASCII.GetBytes(json);
                //udpSendingSocket.SendTo(send_buffer, UDPendPoint);
                 Program.myConnector.storeFrame(values);
            }
            catch (Exception e)
            {
                int x = 0;
                x++;
            }

        }
        public void storevalues()
        {
            names = new List<string>();
            names.Add("RIGHT_HAND_TYPE_THUMB_JOINT_MCPX");
            names.Add("RIGHT_HAND_TYPE_THUMB_JOINT_MCPY");
            names.Add("RIGHT_HAND_TYPE_THUMB_JOINT_MCPZ");

            names.Add("RIGHT_HAND_TYPE_THUMB_JOINT_PIPX");
            names.Add("RIGHT_HAND_TYPE_THUMB_JOINT_PIPY");
            names.Add("RIGHT_HAND_TYPE_THUMB_JOINT_PIPZ");

            names.Add("RIGHT_HAND_TYPE_THUMB_JOINT_DIPX");
            names.Add("RIGHT_HAND_TYPE_THUMB_JOINT_DIPY");
            names.Add("RIGHT_HAND_TYPE_THUMB_JOINT_DIPZ");

            names.Add("RIGHT_HAND_TYPE_THUMB_JOINT_TIPX");
            names.Add("RIGHT_HAND_TYPE_THUMB_JOINT_TIPY");
            names.Add("RIGHT_HAND_TYPE_THUMB_JOINT_TIPZ");


            names.Add("RIGHT_HAND_TYPE_INDEX_JOINT_MCPX");
            names.Add("RIGHT_HAND_TYPE_INDEX_JOINT_MCPY");
            names.Add("RIGHT_HAND_TYPE_INDEX_JOINT_MCPZ");

            names.Add("RIGHT_HAND_TYPE_INDEX_JOINT_PIPX");
            names.Add("RIGHT_HAND_TYPE_INDEX_JOINT_PIPY");
            names.Add("RIGHT_HAND_TYPE_INDEX_JOINT_PIPZ");

            names.Add("RIGHT_HAND_TYPE_INDEX_JOINT_DIPX");
            names.Add("RIGHT_HAND_TYPE_INDEX_JOINT_DIPY");
            names.Add("RIGHT_HAND_TYPE_INDEX_JOINT_DIPZ");

            names.Add("RIGHT_HAND_TYPE_INDEX_JOINT_TIPX");
            names.Add("RIGHT_HAND_TYPE_INDEX_JOINT_TIPY");
            names.Add("RIGHT_HAND_TYPE_INDEX_JOINT_TIPZ");


            names.Add("RIGHT_HAND_TYPE_MIDDLE_JOINT_MCPX");
            names.Add("RIGHT_HAND_TYPE_MIDDLE_JOINT_MCPY");
            names.Add("RIGHT_HAND_TYPE_MIDDLE_JOINT_MCPZ");

            names.Add("RIGHT_HAND_TYPE_MIDDLE_JOINT_PIPX");
            names.Add("RIGHT_HAND_TYPE_MIDDLE_JOINT_PIPY");
            names.Add("RIGHT_HAND_TYPE_MIDDLE_JOINT_PIPZ");

            names.Add("RIGHT_HAND_TYPE_MIDDLE_JOINT_DIPX");
            names.Add("RIGHT_HAND_TYPE_MIDDLE_JOINT_DIPY");
            names.Add("RIGHT_HAND_TYPE_MIDDLE_JOINT_DIPZ");

            names.Add("RIGHT_HAND_TYPE_MIDDLE_JOINT_TIPX");
            names.Add("RIGHT_HAND_TYPE_MIDDLE_JOINT_TIPY");
            names.Add("RIGHT_HAND_TYPE_MIDDLE_JOINT_TIPZ");


            names.Add("RIGHT_HAND_TYPE_RING_JOINT_MCPX");
            names.Add("RIGHT_HAND_TYPE_RING_JOINT_MCPY");
            names.Add("RIGHT_HAND_TYPE_RING_JOINT_MCPZ");

            names.Add("RIGHT_HAND_TYPE_RING_JOINT_PIPX");
            names.Add("RIGHT_HAND_TYPE_RING_JOINT_PIPY");
            names.Add("RIGHT_HAND_TYPE_RING_JOINT_PIPZ");

            names.Add("RIGHT_HAND_TYPE_RING_JOINT_DIPX");
            names.Add("RIGHT_HAND_TYPE_RING_JOINT_DIPY");
            names.Add("RIGHT_HAND_TYPE_RING_JOINT_DIPZ");

            names.Add("RIGHT_HAND_TYPE_RING_JOINT_TIPX");
            names.Add("RIGHT_HAND_TYPE_RING_JOINT_TIPY");
            names.Add("RIGHT_HAND_TYPE_RING_JOINT_TIPZ");


            names.Add("RIGHT_HAND_TYPE_PINKY_JOINT_MCPX");
            names.Add("RIGHT_HAND_TYPE_PINKY_JOINT_MCPY");
            names.Add("RIGHT_HAND_TYPE_PINKY_JOINT_MCPZ");

            names.Add("RIGHT_HAND_TYPE_PINKY_JOINT_PIPX");
            names.Add("RIGHT_HAND_TYPE_PINKY_JOINT_PIPY");
            names.Add("RIGHT_HAND_TYPE_PINKY_JOINT_PIPZ");

            names.Add("RIGHT_HAND_TYPE_PINKY_JOINT_DIPX");
            names.Add("RIGHT_HAND_TYPE_PINKY_JOINT_DIPY");
            names.Add("RIGHT_HAND_TYPE_PINKY_JOINT_DIPZ");

            names.Add("RIGHT_HAND_TYPE_PINKY_JOINT_TIPX");
            names.Add("RIGHT_HAND_TYPE_PINKY_JOINT_TIPY");
            names.Add("RIGHT_HAND_TYPE_PINKY_JOINT_TIPZ");


            names.Add("LEFT_HAND_TYPE_THUMB_JOINT_MCPX");
            names.Add("LEFT_HAND_TYPE_THUMB_JOINT_MCPY");
            names.Add("LEFT_HAND_TYPE_THUMB_JOINT_MCPZ");

            names.Add("LEFT_HAND_TYPE_THUMB_JOINT_PIPX");
            names.Add("LEFTT_HAND_TYPE_THUMB_JOINT_PIPY");
            names.Add("LEFT_HAND_TYPE_THUMB_JOINT_PIPZ");

            names.Add("LEFT_HAND_TYPE_THUMB_JOINT_DIPX");
            names.Add("LEFT_HAND_TYPE_THUMB_JOINT_DIPY");
            names.Add("LEFT_HAND_TYPE_THUMB_JOINT_DIPZ");

            names.Add("LEFT_HAND_TYPE_THUMB_JOINT_TIPX");
            names.Add("LEFT_HAND_TYPE_THUMB_JOINT_TIPY");
            names.Add("LEFT_HAND_TYPE_THUMB_JOINT_TIPZ");


            names.Add("LEFT_HAND_TYPE_INDEX_JOINT_MCPX");
            names.Add("LEFT_HAND_TYPE_INDEX_JOINT_MCPY");
            names.Add("LEFT_HAND_TYPE_INDEX_JOINT_MCPZ");

            names.Add("LEFT_HAND_TYPE_INDEX_JOINT_PIPX");
            names.Add("LEFT_HAND_TYPE_INDEX_JOINT_PIPY");
            names.Add("LEFT_HAND_TYPE_INDEX_JOINT_PIPZ");

            names.Add("LEFT_HAND_TYPE_INDEX_JOINT_DIPX");
            names.Add("LEFT_HAND_TYPE_INDEX_JOINT_DIPY");
            names.Add("LEFT_HAND_TYPE_INDEX_JOINT_DIPZ");

            names.Add("LEFT_HAND_TYPE_INDEX_JOINT_TIPX");
            names.Add("LEFT_HAND_TYPE_INDEX_JOINT_TIPY");
            names.Add("LEFT_HAND_TYPE_INDEX_JOINT_TIPZ");


            names.Add("LEFT_HAND_TYPE_MIDDLE_JOINT_MCPX");
            names.Add("LEFT_HAND_TYPE_MIDDLE_JOINT_MCPY");
            names.Add("LEFT_HAND_TYPE_MIDDLE_JOINT_MCPZ");

            names.Add("LEFT_HAND_TYPE_MIDDLE_JOINT_PIPX");
            names.Add("LEFT_HAND_TYPE_MIDDLE_JOINT_PIPY");
            names.Add("LEFT_HAND_TYPE_MIDDLE_JOINT_PIPZ");

            names.Add("LEFT_HAND_TYPE_MIDDLE_JOINT_DIPX");
            names.Add("LEFT_HAND_TYPE_MIDDLE_JOINT_DIPY");
            names.Add("LEFT_HAND_TYPE_MIDDLE_JOINT_DIPZ");

            names.Add("LEFT_HAND_TYPE_MIDDLE_JOINT_TIPX");
            names.Add("LEFT_HAND_TYPE_MIDDLE_JOINT_TIPY");
            names.Add("LEFT_HAND_TYPE_MIDDLE_JOINT_TIPZ");


            names.Add("LEFT_HAND_TYPE_RING_JOINT_MCPX");
            names.Add("LEFT_HAND_TYPE_RING_JOINT_MCPY");
            names.Add("LEFT_HAND_TYPE_RING_JOINT_MCPZ");

            names.Add("LEFT_HAND_TYPE_RING_JOINT_PIPX");
            names.Add("LEFT_HAND_TYPE_RING_JOINT_PIPY");
            names.Add("LEFT_HAND_TYPE_RING_JOINT_PIPZ");

            names.Add("LEFT_HAND_TYPE_RING_JOINT_DIPX");
            names.Add("LEFT_HAND_TYPE_RING_JOINT_DIPY");
            names.Add("LEFT_HAND_TYPE_RING_JOINT_DIPZ");

            names.Add("LEFT_HAND_TYPE_RING_JOINT_TIPX");
            names.Add("LEFT_HAND_TYPE_RING_JOINT_TIPY");
            names.Add("LEFT_HAND_TYPE_RING_JOINT_TIPZ");


            names.Add("LEFT_HAND_TYPE_PINKY_JOINT_MCPX");
            names.Add("LEFT_HAND_TYPE_PINKY_JOINT_MCPY");
            names.Add("LEFT_HAND_TYPE_PINKY_JOINT_MCPZ");

            names.Add("LEFT_HAND_TYPE_PINKY_JOINT_PIPX");
            names.Add("LEFT_HAND_TYPE_PINKY_JOINT_PIPY");
            names.Add("LEFT_HAND_TYPE_PINKY_JOINT_PIPZ");

            names.Add("LEFT_HAND_TYPE_PINKY_JOINT_DIPX");
            names.Add("LEFT_HAND_TYPE_PINKY_JOINT_DIPY");
            names.Add("LEFT_HAND_TYPE_PINKY_JOINT_DIPZ");

            names.Add("LEFT_HAND_TYPE_PINKY_JOINT_TIPX");
            names.Add("LEFT_HAND_TYPE_PINKY_JOINT_TIPY");
            names.Add("LEFT_HAND_TYPE_PINKY_JOINT_TIPZ");

            Program.myConnector.setValuesName(names);
        }

        //private void myThreadFunction()
        //{
        //    while (isRunning == true)
        //    {
        //        //Creates an IPEndPoint to record the IP Address and port number of the sender. 
        //        // The IPEndPoint will allow you to read datagrams sent from any source.
        //        IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, listeningPort);
        //        try
        //        {

        //            // Blocks until a message returns on this socket from a remote host.
        //            Byte[] receiveBytes = receivingUdp.Receive(ref RemoteIpEndPoint);

        //            string returnData = Encoding.ASCII.GetString(receiveBytes);

        //            Console.WriteLine("This is the message you received " +
        //                                         returnData);

        //            currentString = returnData.ToString();
        //            newPackage = true;
        //            if (Parent.directPush == true)
        //            {
        //                Parent.storeString(currentString);
        //            }
        //        }

        //        catch (Exception e)
        //        {
        //            Console.WriteLine("I got an exception in the Pen thread" + e.ToString());
        //        }
        //    }
        //}
    }
}

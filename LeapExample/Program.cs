using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leap;

namespace LeapExample
{
    
    class Program
    {
        public static ConnectorHub.ConnectorHub myConnector;
        public static List<string> names;
        static Controller controller;
        static SampleListener listener;
        public static bool iRrunning = false;
        static void Main(string[] args)
        {

            try
            {
                int i = 0;
                myConnector = new ConnectorHub.ConnectorHub();

                myConnector.Init();
                setValueNames();

                myConnector.StartRecordingEvent += MyConnector_startRecordingEvent;
                myConnector.StopRecordingEvent += MyConnector_stopRecordingEvent;


            }
            catch
            {

            }

           // setValueNames();
            controller = new Controller();
            listener = new SampleListener();
            controller.Connect += listener.OnServiceConnect;
            controller.Device += listener.OnConnect;
            controller.FrameReady += listener.OnFrame;

            

            // Keep this process running until Enter is pressed
            Console.WriteLine("Press Enter to quit...");
            Console.ReadLine();

           // controller.RemoveListener(listener);
            controller.Dispose();
           
        }

       

        private static void MyConnector_stopRecordingEvent(object sender)
        {
            controller.FrameReady -= listener.OnFrame;
            listener.isRunning = false;
            
        }

        private static  void MyConnector_startRecordingEvent(object sender)
        {
            controller.FrameReady += listener.OnFrame;
            listener.isRunning = true;
        }

        public static void setValueNames()
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

            myConnector.SetValuesName(names);

        }
    }
}

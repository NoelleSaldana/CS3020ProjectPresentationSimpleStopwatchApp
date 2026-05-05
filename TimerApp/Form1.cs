using System.Diagnostics;

namespace TimerApp {

    //Interface for stopwatch, behaviors: Start, Stop, Reset, state variables: Time elapsed, is running
    public interface IStopwatchService {
        void Start();
        void Stop();
        void Reset();
        TimeSpan GetTimeElapsed();
        bool IsRunning { get; }
    }

    //Base class for stopwatch, implements IStopwatchService, uses System.Diagnostics.Stopwatch
    public abstract class StopwatchBase : IStopwatchService {
        protected System.Diagnostics.Stopwatch stopwatch;

        public bool IsRunning => stopwatch.IsRunning;

        public StopwatchBase() {
            stopwatch = new System.Diagnostics.Stopwatch();
        }

        public virtual void Start() {
            stopwatch.Start();
        }

        public virtual void Stop(){
            stopwatch.Stop();
        }

        public virtual void Reset() {
            stopwatch.Reset();
        }

        public virtual TimeSpan GetTimeElapsed() {
            return stopwatch.Elapsed;
        }
    }

    public class ActualStopwatch : StopwatchBase {
        //Empty, all behaviors in base class
    }

    public partial class Form1 : Form {

        private IStopwatchService stopwatch;

        //Load the window and create the stopwatch
        public Form1() {
            InitializeComponent();
            stopwatch = new ActualStopwatch();
        }

        //Update the time passed and the winforms label
        private void timer1_Tick(object sender, EventArgs e) {
            TimeSpan ts = stopwatch.GetTimeElapsed();
            labelTime.Text = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
        }

        //Starts the stopwatch
        private void Start_Button_Click(object sender, EventArgs e) {
            stopwatch.Start();
            timer1.Start();
        }

        //Pauses the stopwatch
        private void Stop_Button_Click(object sender, EventArgs e) {
            stopwatch.Stop();
            timer1.Stop();
        }

        //Resets the time and stops the stopwatch
        private void Reset_Button_Click(object sender, EventArgs e) {
            stopwatch.Reset();
            labelTime.Text = "00:00:00.00";
        }
        
        private void labelTime_Click(object sender, EventArgs e) {
            //Empty because I accidently double clicked the label in the designer,
            //thus creating this event handler,
            //and the program wont run without it... oops
        }
    }
}
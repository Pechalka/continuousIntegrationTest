using System.ServiceProcess;
using System.Timers;

namespace Service
{
    public partial class SiteProcessor : ServiceBase
    {
        private Timer timer;

        public SiteProcessor()
        {
            timer = new Timer(10000D); 

            timer.Elapsed += timer_Elapsed;
            timer.Start();

            InitializeComponent();
        }

        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Loger.AddLog("Tick");
        }


        protected override void OnStart(string[] args)
        {
            timer.Start();
        }

        protected override void OnStop()
        {
            timer.Stop();
        }
    }
}

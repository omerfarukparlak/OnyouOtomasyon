using DevExpress.XtraSplashScreen;
using System;

namespace OnyouOtomasyon
{
    public partial class onyouSplash : SplashScreen
    {
        public onyouSplash()
        {
            InitializeComponent();
            this.labelCopyright.Text = "Copyright © 1998-" + DateTime.Now.Year.ToString();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }
    }
}
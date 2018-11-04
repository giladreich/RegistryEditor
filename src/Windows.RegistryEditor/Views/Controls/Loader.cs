using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Windows.RegistryEditor.Properties;

namespace Windows.RegistryEditor.Views.Controls
{
    public enum LoaderKind
    {
        Clock,
        Arrows,
        CircleBall,
        Loading,
        Snake,
        WheelThrobber
    }

    public partial class Loader : UserControl
    {
        #region --- Fields ---

        private LoaderKind loaderKind;

        #endregion --- Fields ---



        #region --- Properties ---

        [Description("Whether to disable all controls on form when loader is displayed.")]
        [Category("Behavior")]
        public bool DisableControlsOnWork { get; set; }

        [Description("The size of the control when it's spinning. The purpose of this property is " +
                     "to allow you hidding your loader as a very small size in the corner, while " +
                     "being able to specifying the expected size.")]
        [Category("Layout")]
        public Size SizeLoading { get; set; }

        [Description("Gets or sets the loader appearance to be displayed.")]
        [Category("Appearance")]
        public LoaderKind LoaderKind
        {
            get => loaderKind;
            set
            {
                if (value == loaderKind) return;

                loaderKind = value;
                pbxGif.Image = CreateLoaderImage(value);
                if (DesignMode) Invalidate();
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turns on WS_EX_COMPOSITED
                return cp;
            }
        }

        #endregion --- Properties ---


        public Loader()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor |
                     ControlStyles.UserPaint |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.Selectable, true);

            InitializeComponent();

            DoubleBuffered = true;
            Visible = false;
            DisableControlsOnWork = true;
            SizeLoading = new Size(100, 100);
            LoaderKind = LoaderKind.Clock;
        }

        private void Spinner_Load(object sender, EventArgs e)
        {
            if (IsParentNull()) return;

            ParentForm.SizeChanged += delegate { PositionToParent(); };
        }

        private void PositionToParent()
        {
            if (IsParentNull()) return;

            this.Invoke(new Action(() => Left = (ParentForm.ClientSize.Width - Width) / 2));
            this.Invoke(new Action(() => Top = (ParentForm.ClientSize.Height - Height) / 2));
        }

        public new void Show()
        {
            if (IsParentNull() || Visible) return;

            this.Invoke(new Action(() => Size = SizeLoading));

            if (DisableControlsOnWork)
                EnableParentControls(false);

            PositionToParent();

            this.Invoke(new Action(() => base.Show()));
            this.Invoke(new Action(() => BringToFront()));
        }

        public new void Hide()
        {
            if (IsParentNull() || !Visible) return;

            if (DisableControlsOnWork)
                EnableParentControls(true);

            this.Invoke(new Action(() => base.Hide()));
            this.Invoke(new Action(() => SendToBack()));
        }


        private bool IsParentNull([CallerMemberName] string callerMethod = "")
        {
            bool isNull = ParentForm == null;

            if (isNull)
                Debug.WriteLine($"[{callerMethod}] - Parent cannot be null.");

            return isNull;
        }
        private void EnableParentControls(bool enabled)
        {
            if (IsParentNull()) return;

            foreach (Control control in ParentForm.Controls)
            {
                if (control.GetType() == typeof(Loader)) continue;

                control.Invoke(new Action(() => control.Enabled = enabled));
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Transparent(this, e.Graphics);
            base.OnPaint(e);
        }

        public static void Transparent(Control control, Graphics graphics)
        {
            Control owner = control.Parent;
            if (owner == null) return;

            Rectangle controlBounds = control.Bounds;
            ControlCollection ownerControls = owner.Controls;
            int controlIndex = ownerControls.IndexOf(control);
            Bitmap bitmapBehind = null;
            for (int i = controlIndex + 1; i < ownerControls.Count; i++)
            {
                Control targetControl = ownerControls[i];
                if (!targetControl.Bounds.IntersectsWith(controlBounds)) continue;

                if (bitmapBehind == null)
                    bitmapBehind = new Bitmap(control.Parent.ClientSize.Width, control.Parent.ClientSize.Height);
                targetControl.DrawToBitmap(bitmapBehind, targetControl.Bounds);
            }

            if (bitmapBehind == null) return;

            graphics.DrawImage(bitmapBehind, control.ClientRectangle, controlBounds, GraphicsUnit.Pixel);
            bitmapBehind.Dispose();
        }

        private Image CreateLoaderImage(LoaderKind value)
        {
            switch (value)
            {
                case LoaderKind.Clock:
                    return Resources.loader_clock;

                //case LoaderKind.Arrows:
                //    return Resources.loader_arrows;

                //case LoaderKind.CircleBall:
                //    return Resources.loader_circleball;

                //case LoaderKind.Loading:
                //    return Resources.loader_loading;

                //case LoaderKind.Snake:
                //    return Resources.loader_snake;

                //case LoaderKind.WheelThrobber:
                //    return Resources.loader_wheelthrobber;

                default:
                    throw new ArgumentOutOfRangeException(nameof(value), value, null);
            }
        }
    }
}

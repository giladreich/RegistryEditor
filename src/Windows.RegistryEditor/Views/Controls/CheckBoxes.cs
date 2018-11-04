using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Management.Instrumentation;
using System.Reflection;
using System.Windows.Forms;

namespace Windows.RegistryEditor.Views.Controls
{
    public partial class CheckBoxes : UserControl
    {

        public event ItemCheckEventHandler ItemCheck;
        public event EventHandler SelectAllCheckedChanged;

        protected virtual void OnItemCheck(ItemCheckEventArgs e) => ItemCheck?.Invoke(this, e);
        protected virtual void OnSelectAllCheckedChanged() => SelectAllCheckedChanged?.Invoke(this, EventArgs.Empty);

        public CheckBoxes()
        {
            InitializeComponent();
            CheckOnClick = true;
            lbxAll.Dock = DockStyle.Fill;

            foreach (Control control in panelMain.Controls)
                typeof(Control).InvokeMember("DoubleBuffered",
                    BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                    null, control, new object[] { true });
        }

        private void CheckBoxes_Load(object sender, EventArgs e)
        {

        }

        private void CbxAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lbxAll.Items.Count; i++)
            {
                lbxAll.SetItemChecked(i, cbxAll.Checked);
            }

            OnSelectAllCheckedChanged();
        }

        private void LbxAll_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Unchecked)
            {
                cbxAll.CheckedChanged -= CbxAll_CheckedChanged;
                cbxAll.Checked = false;
                cbxAll.CheckedChanged += CbxAll_CheckedChanged;
            }
            else if (lbxAll.Items.Count == lbxAll.CheckedItems.Count + 1 
                     && e.NewValue == CheckState.Checked)
            {
                cbxAll.CheckedChanged -= CbxAll_CheckedChanged;
                cbxAll.Checked = true;
                cbxAll.CheckedChanged += CbxAll_CheckedChanged;
            }

            OnItemCheck(e);
        }

        [Browsable(false)]
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        [MergableProperty(false)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Localizable(true)]
        [Category("Data")]
        [Description("Gets the collection of items in this CheckedListBox.")]
        public CheckedListBox.ObjectCollection Items
        {
            get
            {
                CbxAll_CheckedChanged(null, null); // When new items are added through the designer, check the state of the cbxAll.
                return lbxAll.Items;
            }
        }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Description("CheckedListBox DataSource.")]
        public object DataSource
        {
            get => lbxAll.DataSource;
            set => lbxAll.DataSource = value;
        }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Deprecated", false)]
        public new Image BackgroundImage { get; set; }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public new ImageLayout BackgroundImageLayout { get; set; }

        public new Color BackColor
        {
            get => lbxAll.BackColor;
            set => UpdateControl(() => lbxAll.BackColor = value);
        }

        public new BorderStyle BorderStyle
        {
            get => lbxAll.BorderStyle;
            set => UpdateControl(() => lbxAll.BorderStyle = value);
        }

        public new Color ForeColor
        {
            get => lbxAll.ForeColor;
            set => UpdateControl(() => lbxAll.ForeColor = value);
        }

        [Category("Appearance")]
        [Description("Indicates if the CheckBoxes should show up as flat or 3D in appearance.")]
        public bool ThreeDCheckBoxes
        {
            get => lbxAll.ThreeDCheckBoxes;
            set => UpdateControl(() => lbxAll.ThreeDCheckBoxes = value);
        }

        [Category("Behavior")]
        [Description("Indicates if the check box should be toggled with the first click on an item.")]
        public bool CheckOnClick
        {
            get => lbxAll.CheckOnClick;
            set => lbxAll.CheckOnClick = value;
        }


        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Collection of checked items in this CheckedListBox.")]
        public CheckedListBox.CheckedItemCollection CheckedItems => lbxAll.CheckedItems;

        [Browsable(true)]
        [Description("Indicates if all check boxes are checked in the CheckedListBox.")]
        [Category("Appearance")]
        public bool SelectAllChecked
        {
            get => cbxAll.Checked;
            set => UpdateControl(() => cbxAll.Checked = value);
        }

        public void UpdateControl(Action action)
        {
            action.Invoke();
            if (DesignMode) Invalidate();
        }

        /// <summary>
        /// Sets the checked value of the given item.  This value should be a boolean.
        /// </summary>
        public void SetItemChecked(int index, bool value)
        {
            lbxAll.SetItemChecked(index, value);
        }

        /// <summary>
        /// Sets the checked value of the given item.  This value should be from
        /// the System.Windows.Forms.CheckState enumeration.
        /// </summary>
        public void SetItemCheckState(int index, CheckState value)
        {
            lbxAll.SetItemCheckState(index, value);
        }

        /// <summary>
        /// Indicates if the given item is, in any way, shape, or form, checked.
        /// This will return true if the item is fully or indeterminately checked.
        /// </summary>
        public bool GetItemChecked(int index)
        {
            return lbxAll.GetItemChecked(index);
        }

        /// <summary>
        /// Gets the check value of the current item.  This value will be from the
        /// System.Windows.Forms.CheckState enumeration.
        /// </summary>
        public CheckState GetItemCheckState(int index)
        {
            return lbxAll.GetItemCheckState(index);
        }

        public void SetItemCheckedByName(string value, bool flag)
        {
            for (int i = 0; i < lbxAll.Items.Count; i++)
            {
                if (lbxAll.Items[i].ToString().Equals(value))
                    lbxAll.SetItemChecked(i, flag);
            }

            throw new InstanceNotFoundException($"[SetItemCheckedByName] - Couldn't find the specified value -> {value}.");
        }

        public bool GetItemCheckedByName(string value)
        {
            for (int i = 0; i < lbxAll.Items.Count; i++)
            {
                if (lbxAll.Items[i].ToString().Equals(value))
                    return lbxAll.GetItemChecked(i);
            }

            throw new InstanceNotFoundException($"[GetItemCheckedByName] - Couldn't find the specified value -> {value}.");
        }

    }
}

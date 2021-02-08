using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace clipTextChange
{
    public partial class mainForm : Form
    {

        [DllImport("user32.dll", SetLastError = true)]
        private extern static void AddClipboardFormatListener(IntPtr hwnd);

        [DllImport("user32.dll", SetLastError = true)]
        private extern static void RemoveClipboardFormatListener(IntPtr hwnd);

        private const int WM_CLIPBOARDUPDATE = 0x31D;

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            AddClipboardFormatListener(Handle);
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            RemoveClipboardFormatListener(Handle);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_CLIPBOARDUPDATE)
            {
                RemoveClipboardFormatListener(Handle);
                updateClipText();
                m.Result = IntPtr.Zero;
                AddClipboardFormatListener(Handle);
            }
            else
                base.WndProc(ref m);
        }

        private void updateClipText()
        {
            try
            {
                if (Clipboard.ContainsText() && changeEnable.Checked)
                {
                    String orgstr = Clipboard.GetText();

                    String outstr = orgstr.Replace("\n", " ").Replace("\r", " ").Replace("  ", " ");

                    if (addnewlineCode.Checked)
                    {
                        outstr = outstr.Replace(".", ".\n");
                    }

                    if (outstr != null)
                    {
                        Clipboard.SetDataObject(outstr, true, 20, 100);
                    }
                }
            }
            catch(Exception)
            {
                updateClipText();
            }
        }
    }
}

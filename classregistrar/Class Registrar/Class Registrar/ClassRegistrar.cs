using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Registrar
{
    public partial class ClassRegistrar : Form
    {
        public ClassRegistrar()
        {
            InitializeComponent();
        }

        private void AddDirInput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AddProgramDirInputEXE_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AddFileDesc_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AddIconDirInput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            this.output.Text = null;
            string adir = this.AddDirInput.Text;
            string filedesc = this.AddFileDesc.Text;
            if (adir == "")
            {
                this.output.Text = ("Please write a directory!");
            }
            if (adir == ("HKEY_CLASSES_ROOT\\"))
            {
                this.output.Text = ("Must add an extension e.g. HKEY_CLASSES_ROOT\\.ext");
            }
            else
            {
                string[] parts = adir.Split('\\');
                IEnumerable<string> dcs = parts.Where(part => part.StartsWith("."));
                string ext = string.Join("", dcs);
                if (Registry.GetValue(adir, filedesc, null) == null)
                {
                    RegistryKey newkey = Registry.ClassesRoot.CreateSubKey(ext);
                    newkey.SetValue("", filedesc);
                    newkey.Close();
                    this.output.Text = ("Sucess! Key " + ext + " has been registered");
                }
            }
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            output.Text = ("");
            string deldir = DeleteDirInput.Text;
            string[] parts = deldir.Split('\\');
            IEnumerable<string> dcs = parts.Where(part => part.StartsWith("."));
            string ext3 = string.Join("", dcs);
            if (deldir == "")
            {
                this.output.Text = ("Please write a directory!");
            }
            if (deldir == ("HKEY_CLASSES_ROOT\\"))
            {
                this.output.Text = ("Must add an extension e.g. HKEY_CLASSES_ROOT\\.ext");
            }
            else
            {
                Registry.ClassesRoot.DeleteSubKeyTree(ext3);
                output.Text = ("DELETED " + ext3 + " REGISTRATION!!!");
            }
        }
    }
}

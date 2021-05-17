using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hashing_Algorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmbb_hashType.SelectedIndex = 0;
            cmbb_output.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            switch (cmbb_hashType.Text)
            {
                case "SHA-256":
                    switch (cmbb_output.Text)
                    {
                        case "Text":
                            textBox2.Text = Hashing.CalculateHash(textBox1.Text, supportedHash.SHA256, supportedOutput.Text);
                            break;
                        case "Binary":
                            textBox2.Text = Hashing.CalculateHash(textBox1.Text, supportedHash.SHA256, supportedOutput.Binary);
                            break;
                    }
                    break;
                case "SHA-384":
                    switch (cmbb_output.Text)
                    {
                        case "Text":
                            textBox2.Text = Hashing.CalculateHash(textBox1.Text, supportedHash.SHA384, supportedOutput.Text);
                            break;
                        case "Binary":
                            textBox2.Text = Hashing.CalculateHash(textBox1.Text, supportedHash.SHA384, supportedOutput.Binary);
                            break;
                    }
                    break;
                case "SHA-512":
                    switch (cmbb_output.Text)
                    {
                        case "Text":
                            textBox2.Text = Hashing.CalculateHash(textBox1.Text, supportedHash.SHA512, supportedOutput.Text);
                            break;
                        case "Binary":
                            textBox2.Text = Hashing.CalculateHash(textBox1.Text, supportedHash.SHA512, supportedOutput.Binary);
                            break;
                    }
                    break;
            }
        }

        private void cmbb_hashType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbb_hashType.IsHandleCreated && cmbb_hashType.Focused)
            {
                switch (cmbb_hashType.Text)
                {
                    case "SHA-256":
                        switch (cmbb_output.Text)
                        {
                            case "Text":
                                textBox2.Text = Hashing.CalculateHash(textBox1.Text, supportedHash.SHA256, supportedOutput.Text);
                                break;
                            case "Binary":
                                textBox2.Text = Hashing.CalculateHash(textBox1.Text, supportedHash.SHA256, supportedOutput.Binary);
                                break;
                        }
                        break;
                    case "SHA-384":
                        switch (cmbb_output.Text)
                        {
                            case "Text":
                                textBox2.Text = Hashing.CalculateHash(textBox1.Text, supportedHash.SHA384, supportedOutput.Text);
                                break;
                            case "Binary":
                                textBox2.Text = Hashing.CalculateHash(textBox1.Text, supportedHash.SHA384, supportedOutput.Binary);
                                break;
                        }
                        break;
                    case "SHA-512":
                        switch (cmbb_output.Text)
                        {
                            case "Text":
                                textBox2.Text = Hashing.CalculateHash(textBox1.Text, supportedHash.SHA512, supportedOutput.Text);
                                break;
                            case "Binary":
                                textBox2.Text = Hashing.CalculateHash(textBox1.Text, supportedHash.SHA512, supportedOutput.Binary);
                                break;
                        }
                        break;
                }
            }
        }

        private void cmbb_output_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbb_output.IsHandleCreated && cmbb_output.Focused)
            {
                switch (cmbb_hashType.Text)
                {
                    case "SHA-256":
                        switch (cmbb_output.Text)
                        {
                            case "Text":
                                textBox2.Text = Hashing.CalculateHash(textBox1.Text, supportedHash.SHA256, supportedOutput.Text);
                                break;
                            case "Binary":
                                textBox2.Text = Hashing.CalculateHash(textBox1.Text, supportedHash.SHA256, supportedOutput.Binary);
                                break;
                        }
                        break;
                    case "SHA-384":
                        switch (cmbb_output.Text)
                        {
                            case "Text":
                                textBox2.Text = Hashing.CalculateHash(textBox1.Text, supportedHash.SHA384, supportedOutput.Text);
                                break;
                            case "Binary":
                                textBox2.Text = Hashing.CalculateHash(textBox1.Text, supportedHash.SHA384, supportedOutput.Binary);
                                break;
                        }
                        break;
                    case "SHA-512":
                        switch (cmbb_output.Text)
                        {
                            case "Text":
                                textBox2.Text = Hashing.CalculateHash(textBox1.Text, supportedHash.SHA512, supportedOutput.Text);
                                break;
                            case "Binary":
                                textBox2.Text = Hashing.CalculateHash(textBox1.Text, supportedHash.SHA512, supportedOutput.Binary);
                                break;
                        }
                        break;
                }
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace steganography {
    public partial class HelpForm : Form {
        public HelpForm() {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}

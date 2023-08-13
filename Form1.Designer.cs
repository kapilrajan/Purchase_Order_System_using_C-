namespace Purchase_Order_System_using_C_
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkpaint = new System.Windows.Forms.CheckBox();
            this.checktyre = new System.Windows.Forms.CheckBox();
            this.checkwheel = new System.Windows.Forms.CheckBox();
            this.checkoil = new System.Windows.Forms.CheckBox();
            this.checkgeneral = new System.Windows.Forms.CheckBox();
            this.checkwash = new System.Windows.Forms.CheckBox();
            this.add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.texttotal = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OliveDrab;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 68);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kapil Car Repair Shop";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkpaint);
            this.groupBox1.Controls.Add(this.checktyre);
            this.groupBox1.Controls.Add(this.checkwheel);
            this.groupBox1.Controls.Add(this.checkoil);
            this.groupBox1.Controls.Add(this.checkgeneral);
            this.groupBox1.Controls.Add(this.checkwash);
            this.groupBox1.Location = new System.Drawing.Point(44, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 131);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Repair";
            // 
            // checkpaint
            // 
            this.checkpaint.AutoSize = true;
            this.checkpaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkpaint.Location = new System.Drawing.Point(243, 94);
            this.checkpaint.Name = "checkpaint";
            this.checkpaint.Size = new System.Drawing.Size(72, 17);
            this.checkpaint.TabIndex = 5;
            this.checkpaint.Text = "Painting";
            this.checkpaint.UseVisualStyleBackColor = true;
            // 
            // checktyre
            // 
            this.checktyre.AutoSize = true;
            this.checktyre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checktyre.Location = new System.Drawing.Point(73, 94);
            this.checktyre.Name = "checktyre";
            this.checktyre.Size = new System.Drawing.Size(98, 17);
            this.checktyre.TabIndex = 4;
            this.checktyre.Text = "Tyre Change";
            this.checktyre.UseVisualStyleBackColor = true;
            // 
            // checkwheel
            // 
            this.checkwheel.AutoSize = true;
            this.checkwheel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkwheel.Location = new System.Drawing.Point(243, 54);
            this.checkwheel.Name = "checkwheel";
            this.checkwheel.Size = new System.Drawing.Size(121, 17);
            this.checkwheel.TabIndex = 3;
            this.checkwheel.Text = "Wheel Alignment";
            this.checkwheel.UseVisualStyleBackColor = true;
            // 
            // checkoil
            // 
            this.checkoil.AutoSize = true;
            this.checkoil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoil.Location = new System.Drawing.Point(73, 54);
            this.checkoil.Name = "checkoil";
            this.checkoil.Size = new System.Drawing.Size(88, 17);
            this.checkoil.TabIndex = 2;
            this.checkoil.Text = "Oil Change";
            this.checkoil.UseVisualStyleBackColor = true;
            // 
            // checkgeneral
            // 
            this.checkgeneral.AutoSize = true;
            this.checkgeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkgeneral.Location = new System.Drawing.Point(243, 20);
            this.checkgeneral.Name = "checkgeneral";
            this.checkgeneral.Size = new System.Drawing.Size(117, 17);
            this.checkgeneral.TabIndex = 1;
            this.checkgeneral.Text = "General Service";
            this.checkgeneral.UseVisualStyleBackColor = true;
            // 
            // checkwash
            // 
            this.checkwash.AutoSize = true;
            this.checkwash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkwash.Location = new System.Drawing.Point(73, 20);
            this.checkwash.Name = "checkwash";
            this.checkwash.Size = new System.Drawing.Size(81, 17);
            this.checkwash.TabIndex = 0;
            this.checkwash.Text = "Car Wash";
            this.checkwash.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Olive;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(515, 119);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(127, 39);
            this.add.TabIndex = 2;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(532, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total";
            // 
            // texttotal
            // 
            this.texttotal.BackColor = System.Drawing.Color.Black;
            this.texttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texttotal.ForeColor = System.Drawing.Color.Yellow;
            this.texttotal.Location = new System.Drawing.Point(473, 227);
            this.texttotal.Name = "texttotal";
            this.texttotal.Size = new System.Drawing.Size(219, 49);
            this.texttotal.TabIndex = 4;
            this.texttotal.TextChanged += new System.EventHandler(this.texttotal_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item,
            this.price,
            this.delete});
            this.dataGridView1.Location = new System.Drawing.Point(44, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 162);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // item
            // 
            this.item.HeaderText = "Item";
            this.item.Name = "item";
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // delete
            // 
            this.delete.HeaderText = "Delete";
            this.delete.Name = "delete";
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.delete.Text = "Delete";
            this.delete.UseColumnTextForButtonValue = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.texttotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.add);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkpaint;
        private System.Windows.Forms.CheckBox checktyre;
        private System.Windows.Forms.CheckBox checkwheel;
        private System.Windows.Forms.CheckBox checkoil;
        private System.Windows.Forms.CheckBox checkgeneral;
        private System.Windows.Forms.CheckBox checkwash;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox texttotal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}
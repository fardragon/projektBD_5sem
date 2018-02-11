namespace CarDealership.Forms
{
    partial class AddCar
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
            this.components = new System.ComponentModel.Container();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ModelComboBox = new System.Windows.Forms.ComboBox();
            this.modelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelsDataSet = new CarDealership.ModelsDataSet();
            this.modelsTableAdapter = new CarDealership.ModelsDataSetTableAdapters.ModelsTableAdapter();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.ColorsComboBox = new System.Windows.Forms.ComboBox();
            this.colorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colorsDataSet = new CarDealership.ColorsDataSet();
            this.colorsTableAdapter = new CarDealership.ColorsDataSetTableAdapters.ColorsTableAdapter();
            this.ProdYearLabel = new System.Windows.Forms.Label();
            this.VINLabel = new System.Windows.Forms.Label();
            this.ProdYearTextbox = new System.Windows.Forms.MaskedTextBox();
            this.VINTextbox = new System.Windows.Forms.MaskedTextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddNextButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ExitButton = new System.Windows.Forms.Button();
            this.PickAccessoriessButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(17, 36);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(39, 13);
            this.ModelLabel.TabIndex = 0;
            this.ModelLabel.Text = "Model:";
            // 
            // ModelComboBox
            // 
            this.ModelComboBox.DataSource = this.modelsBindingSource;
            this.ModelComboBox.DisplayMember = "NAME";
            this.ModelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModelComboBox.FormattingEnabled = true;
            this.ModelComboBox.Location = new System.Drawing.Point(77, 33);
            this.ModelComboBox.Name = "ModelComboBox";
            this.ModelComboBox.Size = new System.Drawing.Size(195, 21);
            this.ModelComboBox.TabIndex = 1;
            this.ModelComboBox.ValueMember = "MODEL_ID";
            // 
            // modelsBindingSource
            // 
            this.modelsBindingSource.DataMember = "Models";
            this.modelsBindingSource.DataSource = this.modelsDataSet;
            // 
            // modelsDataSet
            // 
            this.modelsDataSet.DataSetName = "ModelsDataSet";
            this.modelsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modelsTableAdapter
            // 
            this.modelsTableAdapter.ClearBeforeFill = true;
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(17, 63);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(34, 13);
            this.ColorLabel.TabIndex = 2;
            this.ColorLabel.Text = "Color:";
            // 
            // ColorsComboBox
            // 
            this.ColorsComboBox.DataSource = this.colorsBindingSource;
            this.ColorsComboBox.DisplayMember = "NAME";
            this.ColorsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorsComboBox.FormattingEnabled = true;
            this.ColorsComboBox.Location = new System.Drawing.Point(77, 60);
            this.ColorsComboBox.Name = "ColorsComboBox";
            this.ColorsComboBox.Size = new System.Drawing.Size(195, 21);
            this.ColorsComboBox.TabIndex = 3;
            this.ColorsComboBox.ValueMember = "COLOR_ID";
            // 
            // colorsBindingSource
            // 
            this.colorsBindingSource.DataMember = "Colors";
            this.colorsBindingSource.DataSource = this.colorsDataSet;
            // 
            // colorsDataSet
            // 
            this.colorsDataSet.DataSetName = "ColorsDataSet";
            this.colorsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colorsTableAdapter
            // 
            this.colorsTableAdapter.ClearBeforeFill = true;
            // 
            // ProdYearLabel
            // 
            this.ProdYearLabel.AutoSize = true;
            this.ProdYearLabel.Location = new System.Drawing.Point(17, 90);
            this.ProdYearLabel.Name = "ProdYearLabel";
            this.ProdYearLabel.Size = new System.Drawing.Size(86, 13);
            this.ProdYearLabel.TabIndex = 4;
            this.ProdYearLabel.Text = "Production Year:";
            // 
            // VINLabel
            // 
            this.VINLabel.AutoSize = true;
            this.VINLabel.Location = new System.Drawing.Point(17, 116);
            this.VINLabel.Name = "VINLabel";
            this.VINLabel.Size = new System.Drawing.Size(28, 13);
            this.VINLabel.TabIndex = 6;
            this.VINLabel.Text = "VIN:";
            // 
            // ProdYearTextbox
            // 
            this.ProdYearTextbox.AsciiOnly = true;
            this.ProdYearTextbox.BeepOnError = true;
            this.ProdYearTextbox.Location = new System.Drawing.Point(138, 87);
            this.ProdYearTextbox.Mask = "0000";
            this.ProdYearTextbox.Name = "ProdYearTextbox";
            this.ProdYearTextbox.Size = new System.Drawing.Size(30, 20);
            this.ProdYearTextbox.TabIndex = 8;
            this.ProdYearTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ProdYearTextbox.ValidatingType = typeof(int);
            // 
            // VINTextbox
            // 
            this.VINTextbox.AsciiOnly = true;
            this.VINTextbox.BeepOnError = true;
            this.VINTextbox.Location = new System.Drawing.Point(60, 113);
            this.VINTextbox.Mask = "AAAAAAAAAAAAAAAAA";
            this.VINTextbox.Name = "VINTextbox";
            this.VINTextbox.Size = new System.Drawing.Size(121, 20);
            this.VINTextbox.TabIndex = 9;
            // 
            // AddButton
            // 
            this.AddButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.AddButton.Location = new System.Drawing.Point(106, 168);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddNextButton
            // 
            this.AddNextButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.AddNextButton.Location = new System.Drawing.Point(197, 168);
            this.AddNextButton.Name = "AddNextButton";
            this.AddNextButton.Size = new System.Drawing.Size(75, 23);
            this.AddNextButton.TabIndex = 12;
            this.AddNextButton.Text = "Add Next";
            this.AddNextButton.UseVisualStyleBackColor = true;
            this.AddNextButton.Click += new System.EventHandler(this.AddNextButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Location = new System.Drawing.Point(12, 168);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 13;
            this.ExitButton.Text = "Cancel";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // PickAccessoriessButton
            // 
            this.PickAccessoriessButton.Location = new System.Drawing.Point(106, 139);
            this.PickAccessoriessButton.Name = "PickAccessoriessButton";
            this.PickAccessoriessButton.Size = new System.Drawing.Size(166, 23);
            this.PickAccessoriessButton.TabIndex = 14;
            this.PickAccessoriessButton.Text = "Pick acessorries";
            this.PickAccessoriessButton.UseVisualStyleBackColor = true;
            this.PickAccessoriessButton.Click += new System.EventHandler(this.PickAccessoriessButton_Click);
            // 
            // AddCar
            // 
            this.AcceptButton = this.AddNextButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(284, 202);
            this.ControlBox = false;
            this.Controls.Add(this.PickAccessoriessButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AddNextButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.VINTextbox);
            this.Controls.Add(this.ProdYearTextbox);
            this.Controls.Add(this.VINLabel);
            this.Controls.Add(this.ProdYearLabel);
            this.Controls.Add(this.ColorsComboBox);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.ModelComboBox);
            this.Controls.Add(this.ModelLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddCar";
            this.Text = "AddCar";
            this.Load += new System.EventHandler(this.AddCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.ComboBox ModelComboBox;
        private ModelsDataSet modelsDataSet;
        private System.Windows.Forms.BindingSource modelsBindingSource;
        private ModelsDataSetTableAdapters.ModelsTableAdapter modelsTableAdapter;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.ComboBox ColorsComboBox;
        private ColorsDataSet colorsDataSet;
        private System.Windows.Forms.BindingSource colorsBindingSource;
        private ColorsDataSetTableAdapters.ColorsTableAdapter colorsTableAdapter;
        private System.Windows.Forms.Label ProdYearLabel;
        private System.Windows.Forms.Label VINLabel;
        private System.Windows.Forms.MaskedTextBox ProdYearTextbox;
        private System.Windows.Forms.MaskedTextBox VINTextbox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button AddNextButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button PickAccessoriessButton;
    }
}
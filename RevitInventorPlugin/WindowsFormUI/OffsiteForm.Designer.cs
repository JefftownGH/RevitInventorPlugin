﻿namespace RevitInventorExchange.WindowsFormUI
{
    partial class OffsiteForm
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
            this.btnProperties = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExportPropVals = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSOW = new System.Windows.Forms.TabPage();
            this.dgElements = new System.Windows.Forms.DataGridView();
            this.tabMappings = new System.Windows.Forms.TabPage();
            this.richTextBoxLogs = new System.Windows.Forms.RichTextBox();
            this.grpBoxRevitFamilies = new System.Windows.Forms.GroupBox();
            this.btnRevitParametersSel = new System.Windows.Forms.Button();
            this.dgParamsMapping = new System.Windows.Forms.DataGridView();
            this.grpBoxInventorTemplates = new System.Windows.Forms.GroupBox();
            this.btnSelectFromScope = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtInventorTemplatesPath = new System.Windows.Forms.TextBox();
            this.dgInvRevMapping = new System.Windows.Forms.DataGridView();
            this.folderBrowserDialogInventorTemplates = new System.Windows.Forms.FolderBrowserDialog();
            this.btnClearLogs = new System.Windows.Forms.Button();
            this.btnClearSelectedMapping = new System.Windows.Forms.Button();
            this.btnClearSelectedParamMapping = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabSOW.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgElements)).BeginInit();
            this.tabMappings.SuspendLayout();
            this.grpBoxRevitFamilies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgParamsMapping)).BeginInit();
            this.grpBoxInventorTemplates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvRevMapping)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProperties
            // 
            this.btnProperties.Location = new System.Drawing.Point(27, 1031);
            this.btnProperties.Margin = new System.Windows.Forms.Padding(2);
            this.btnProperties.Name = "btnProperties";
            this.btnProperties.Size = new System.Drawing.Size(244, 48);
            this.btnProperties.TabIndex = 1;
            this.btnProperties.Text = "Show Properties";
            this.btnProperties.UseVisualStyleBackColor = true;
            this.btnProperties.Click += new System.EventHandler(this.btnProperties_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(2484, 1388);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(214, 48);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExportPropVals
            // 
            this.btnExportPropVals.Location = new System.Drawing.Point(2107, 1388);
            this.btnExportPropVals.Name = "btnExportPropVals";
            this.btnExportPropVals.Size = new System.Drawing.Size(301, 47);
            this.btnExportPropVals.TabIndex = 3;
            this.btnExportPropVals.Text = "Generate Inventor files";
            this.btnExportPropVals.UseVisualStyleBackColor = true;
            this.btnExportPropVals.Click += new System.EventHandler(this.btnExportPropVals_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSOW);
            this.tabControl1.Controls.Add(this.tabMappings);
            this.tabControl1.Location = new System.Drawing.Point(13, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2693, 1347);
            this.tabControl1.TabIndex = 5;
            // 
            // tabSOW
            // 
            this.tabSOW.Controls.Add(this.dgElements);
            this.tabSOW.Controls.Add(this.btnProperties);
            this.tabSOW.Location = new System.Drawing.Point(8, 39);
            this.tabSOW.Name = "tabSOW";
            this.tabSOW.Padding = new System.Windows.Forms.Padding(3);
            this.tabSOW.Size = new System.Drawing.Size(2677, 1218);
            this.tabSOW.TabIndex = 0;
            this.tabSOW.Text = "Scope of work";
            this.tabSOW.UseVisualStyleBackColor = true;
            // 
            // dgElements
            // 
            this.dgElements.AllowUserToAddRows = false;
            this.dgElements.AllowUserToDeleteRows = false;
            this.dgElements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgElements.Location = new System.Drawing.Point(27, 25);
            this.dgElements.Margin = new System.Windows.Forms.Padding(2);
            this.dgElements.Name = "dgElements";
            this.dgElements.ReadOnly = true;
            this.dgElements.RowHeadersWidth = 102;
            this.dgElements.RowTemplate.Height = 40;
            this.dgElements.Size = new System.Drawing.Size(1928, 961);
            this.dgElements.TabIndex = 0;
            this.dgElements.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgElements_ColumnHeaderMouseClick);
            // 
            // tabMappings
            // 
            this.tabMappings.Controls.Add(this.btnClearLogs);
            this.tabMappings.Controls.Add(this.richTextBoxLogs);
            this.tabMappings.Controls.Add(this.grpBoxRevitFamilies);
            this.tabMappings.Controls.Add(this.grpBoxInventorTemplates);
            this.tabMappings.Location = new System.Drawing.Point(8, 39);
            this.tabMappings.Name = "tabMappings";
            this.tabMappings.Padding = new System.Windows.Forms.Padding(3);
            this.tabMappings.Size = new System.Drawing.Size(2677, 1300);
            this.tabMappings.TabIndex = 1;
            this.tabMappings.Text = "Mappings";
            this.tabMappings.UseVisualStyleBackColor = true;
            // 
            // richTextBoxLogs
            // 
            this.richTextBoxLogs.Location = new System.Drawing.Point(17, 928);
            this.richTextBoxLogs.Name = "richTextBoxLogs";
            this.richTextBoxLogs.Size = new System.Drawing.Size(1284, 295);
            this.richTextBoxLogs.TabIndex = 4;
            this.richTextBoxLogs.Text = "";
            // 
            // grpBoxRevitFamilies
            // 
            this.grpBoxRevitFamilies.Controls.Add(this.btnClearSelectedParamMapping);
            this.grpBoxRevitFamilies.Controls.Add(this.btnRevitParametersSel);
            this.grpBoxRevitFamilies.Controls.Add(this.dgParamsMapping);
            this.grpBoxRevitFamilies.Location = new System.Drawing.Point(1307, 18);
            this.grpBoxRevitFamilies.Name = "grpBoxRevitFamilies";
            this.grpBoxRevitFamilies.Size = new System.Drawing.Size(1334, 888);
            this.grpBoxRevitFamilies.TabIndex = 3;
            this.grpBoxRevitFamilies.TabStop = false;
            this.grpBoxRevitFamilies.Text = "Parameters Mapping";
            // 
            // btnRevitParametersSel
            // 
            this.btnRevitParametersSel.Location = new System.Drawing.Point(20, 833);
            this.btnRevitParametersSel.Name = "btnRevitParametersSel";
            this.btnRevitParametersSel.Size = new System.Drawing.Size(270, 41);
            this.btnRevitParametersSel.TabIndex = 1;
            this.btnRevitParametersSel.Text = "Select Revit Parameters";
            this.btnRevitParametersSel.UseVisualStyleBackColor = true;
            this.btnRevitParametersSel.Click += new System.EventHandler(this.btnRevitParametersSel_Click);
            // 
            // dgParamsMapping
            // 
            this.dgParamsMapping.AllowUserToAddRows = false;
            this.dgParamsMapping.AllowUserToDeleteRows = false;
            this.dgParamsMapping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgParamsMapping.Location = new System.Drawing.Point(20, 103);
            this.dgParamsMapping.Name = "dgParamsMapping";
            this.dgParamsMapping.ReadOnly = true;
            this.dgParamsMapping.RowHeadersWidth = 82;
            this.dgParamsMapping.RowTemplate.Height = 33;
            this.dgParamsMapping.Size = new System.Drawing.Size(1290, 702);
            this.dgParamsMapping.TabIndex = 0;
            // 
            // grpBoxInventorTemplates
            // 
            this.grpBoxInventorTemplates.Controls.Add(this.btnClearSelectedMapping);
            this.grpBoxInventorTemplates.Controls.Add(this.btnSelectFromScope);
            this.grpBoxInventorTemplates.Controls.Add(this.btnBrowse);
            this.grpBoxInventorTemplates.Controls.Add(this.txtInventorTemplatesPath);
            this.grpBoxInventorTemplates.Controls.Add(this.dgInvRevMapping);
            this.grpBoxInventorTemplates.Location = new System.Drawing.Point(17, 18);
            this.grpBoxInventorTemplates.Name = "grpBoxInventorTemplates";
            this.grpBoxInventorTemplates.Size = new System.Drawing.Size(1284, 888);
            this.grpBoxInventorTemplates.TabIndex = 2;
            this.grpBoxInventorTemplates.TabStop = false;
            this.grpBoxInventorTemplates.Text = "Inventor Templates - Revit Families mappings";
            // 
            // btnSelectFromScope
            // 
            this.btnSelectFromScope.Location = new System.Drawing.Point(17, 833);
            this.btnSelectFromScope.Name = "btnSelectFromScope";
            this.btnSelectFromScope.Size = new System.Drawing.Size(270, 41);
            this.btnSelectFromScope.TabIndex = 1;
            this.btnSelectFromScope.Text = "Select Revit Families";
            this.btnSelectFromScope.UseVisualStyleBackColor = true;
            this.btnSelectFromScope.Click += new System.EventHandler(this.btnSelectFromScope_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(1081, 37);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(179, 42);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtInventorTemplatesPath
            // 
            this.txtInventorTemplatesPath.Location = new System.Drawing.Point(17, 39);
            this.txtInventorTemplatesPath.Name = "txtInventorTemplatesPath";
            this.txtInventorTemplatesPath.Size = new System.Drawing.Size(1058, 31);
            this.txtInventorTemplatesPath.TabIndex = 1;
            // 
            // dgInvRevMapping
            // 
            this.dgInvRevMapping.AllowUserToAddRows = false;
            this.dgInvRevMapping.AllowUserToDeleteRows = false;
            this.dgInvRevMapping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInvRevMapping.Location = new System.Drawing.Point(16, 103);
            this.dgInvRevMapping.Name = "dgInvRevMapping";
            this.dgInvRevMapping.ReadOnly = true;
            this.dgInvRevMapping.RowHeadersWidth = 82;
            this.dgInvRevMapping.RowTemplate.Height = 33;
            this.dgInvRevMapping.Size = new System.Drawing.Size(1244, 702);
            this.dgInvRevMapping.TabIndex = 0;
            this.dgInvRevMapping.SelectionChanged += new System.EventHandler(this.dgInvRevMapping_SelectionChanged);
            // 
            // btnClearLogs
            // 
            this.btnClearLogs.Location = new System.Drawing.Point(17, 1241);
            this.btnClearLogs.Name = "btnClearLogs";
            this.btnClearLogs.Size = new System.Drawing.Size(221, 41);
            this.btnClearLogs.TabIndex = 5;
            this.btnClearLogs.Text = "Clear Logs";
            this.btnClearLogs.UseVisualStyleBackColor = true;
            this.btnClearLogs.Click += new System.EventHandler(this.btnClearLogs_Click);
            // 
            // btnClearSelectedMapping
            // 
            this.btnClearSelectedMapping.Location = new System.Drawing.Point(1039, 833);
            this.btnClearSelectedMapping.Name = "btnClearSelectedMapping";
            this.btnClearSelectedMapping.Size = new System.Drawing.Size(221, 41);
            this.btnClearSelectedMapping.TabIndex = 6;
            this.btnClearSelectedMapping.Text = "Clear Selection";
            this.btnClearSelectedMapping.UseVisualStyleBackColor = true;
            this.btnClearSelectedMapping.Click += new System.EventHandler(this.btnClearSelectedMapping_Click);
            // 
            // btnClearSelectedParamMapping
            // 
            this.btnClearSelectedParamMapping.Location = new System.Drawing.Point(1089, 833);
            this.btnClearSelectedParamMapping.Name = "btnClearSelectedParamMapping";
            this.btnClearSelectedParamMapping.Size = new System.Drawing.Size(221, 41);
            this.btnClearSelectedParamMapping.TabIndex = 7;
            this.btnClearSelectedParamMapping.Text = "Clear Selection";
            this.btnClearSelectedParamMapping.UseVisualStyleBackColor = true;
            this.btnClearSelectedParamMapping.Click += new System.EventHandler(this.btnClearSelectedParamMapping_Click);
            // 
            // OffsiteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2726, 1456);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnExportPropVals);
            this.Controls.Add(this.btnCancel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OffsiteForm";
            this.Text = "Offsite Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OffsiteForm_FormClosing);
            this.Load += new System.EventHandler(this.ElementsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabSOW.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgElements)).EndInit();
            this.tabMappings.ResumeLayout(false);
            this.grpBoxRevitFamilies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgParamsMapping)).EndInit();
            this.grpBoxInventorTemplates.ResumeLayout(false);
            this.grpBoxInventorTemplates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvRevMapping)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnProperties;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExportPropVals;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSOW;
        private System.Windows.Forms.DataGridView dgElements;
        private System.Windows.Forms.TabPage tabMappings;
        private System.Windows.Forms.GroupBox grpBoxInventorTemplates;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtInventorTemplatesPath;
        private System.Windows.Forms.DataGridView dgInvRevMapping;
        private System.Windows.Forms.GroupBox grpBoxRevitFamilies;
        private System.Windows.Forms.Button btnSelectFromScope;
        private System.Windows.Forms.DataGridView dgParamsMapping;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogInventorTemplates;
        private System.Windows.Forms.Button btnRevitParametersSel;
        private System.Windows.Forms.RichTextBox richTextBoxLogs;
        private System.Windows.Forms.Button btnClearLogs;
        private System.Windows.Forms.Button btnClearSelectedParamMapping;
        private System.Windows.Forms.Button btnClearSelectedMapping;
    }
}
﻿using System;

namespace MstscManager
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerIp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOpen = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ServerUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerDomain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnBatOpen = new System.Windows.Forms.Button();
            this.txtDesktopwidth = new System.Windows.Forms.TextBox();
            this.txtDesktopheight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ddlGroup = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ddlColor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.Group,
            this.ServerName,
            this.ServerIp,
            this.btnOpen,
            this.ServerUserName,
            this.ServerDomain,
            this.ServerPassword});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(427, 561);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Index
            // 
            this.Index.DataPropertyName = "Index";
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = "0";
            this.Index.DefaultCellStyle = dataGridViewCellStyle4;
            this.Index.HeaderText = "排序";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Visible = false;
            this.Index.Width = 54;
            // 
            // Group
            // 
            this.Group.DataPropertyName = "Group";
            this.Group.HeaderText = "分组";
            this.Group.Name = "Group";
            this.Group.ReadOnly = true;
            this.Group.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Group.Width = 35;
            // 
            // ServerName
            // 
            this.ServerName.DataPropertyName = "ServerName";
            this.ServerName.HeaderText = "名称";
            this.ServerName.Name = "ServerName";
            this.ServerName.ReadOnly = true;
            this.ServerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ServerName.Width = 35;
            // 
            // ServerIp
            // 
            this.ServerIp.DataPropertyName = "ServerIp";
            this.ServerIp.HeaderText = "服务器";
            this.ServerIp.Name = "ServerIp";
            this.ServerIp.ReadOnly = true;
            this.ServerIp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ServerIp.Width = 47;
            // 
            // btnOpen
            // 
            this.btnOpen.HeaderText = "";
            this.btnOpen.MinimumWidth = 20;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.ReadOnly = true;
            this.btnOpen.Text = "打开";
            this.btnOpen.UseColumnTextForButtonValue = true;
            this.btnOpen.Width = 20;
            // 
            // ServerUserName
            // 
            this.ServerUserName.DataPropertyName = "ServerUserName";
            this.ServerUserName.HeaderText = "帐号";
            this.ServerUserName.Name = "ServerUserName";
            this.ServerUserName.ReadOnly = true;
            this.ServerUserName.Visible = false;
            this.ServerUserName.Width = 54;
            // 
            // ServerDomain
            // 
            this.ServerDomain.DataPropertyName = "ServerDomain";
            this.ServerDomain.HeaderText = "域名";
            this.ServerDomain.Name = "ServerDomain";
            this.ServerDomain.ReadOnly = true;
            this.ServerDomain.Visible = false;
            this.ServerDomain.Width = 54;
            // 
            // ServerPassword
            // 
            this.ServerPassword.DataPropertyName = "ServerPassword";
            this.ServerPassword.HeaderText = "密码";
            this.ServerPassword.Name = "ServerPassword";
            this.ServerPassword.ReadOnly = true;
            this.ServerPassword.Visible = false;
            this.ServerPassword.Width = 54;
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(49, 195);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(54, 23);
            this.btnConfig.TabIndex = 1;
            this.btnConfig.Text = "配置";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnBatOpen
            // 
            this.btnBatOpen.Location = new System.Drawing.Point(28, 166);
            this.btnBatOpen.Name = "btnBatOpen";
            this.btnBatOpen.Size = new System.Drawing.Size(75, 23);
            this.btnBatOpen.TabIndex = 2;
            this.btnBatOpen.Text = "批量打开";
            this.btnBatOpen.UseVisualStyleBackColor = true;
            this.btnBatOpen.Click += new System.EventHandler(this.btnBatOpen_Click);
            // 
            // txtDesktopwidth
            // 
            this.txtDesktopwidth.Location = new System.Drawing.Point(3, 27);
            this.txtDesktopwidth.Name = "txtDesktopwidth";
            this.txtDesktopwidth.Size = new System.Drawing.Size(100, 21);
            this.txtDesktopwidth.TabIndex = 3;
            this.txtDesktopwidth.Text = "1920";
            this.txtDesktopwidth.TextChanged += new System.EventHandler(this.txtDesktopwidth_TextChanged);
            // 
            // txtDesktopheight
            // 
            this.txtDesktopheight.Location = new System.Drawing.Point(3, 55);
            this.txtDesktopheight.Name = "txtDesktopheight";
            this.txtDesktopheight.Size = new System.Drawing.Size(100, 21);
            this.txtDesktopheight.TabIndex = 4;
            this.txtDesktopheight.Text = "1080";
            this.txtDesktopheight.TextChanged += new System.EventHandler(this.txtDesktopheight_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "分辨率";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.ddlColor);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ddlGroup);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnConfig);
            this.panel1.Controls.Add(this.txtDesktopheight);
            this.panel1.Controls.Add(this.btnBatOpen);
            this.panel1.Controls.Add(this.txtDesktopwidth);
            this.panel1.Location = new System.Drawing.Point(434, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 561);
            this.panel1.TabIndex = 6;
            // 
            // ddlGroup
            // 
            this.ddlGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlGroup.FormattingEnabled = true;
            this.ddlGroup.Location = new System.Drawing.Point(5, 140);
            this.ddlGroup.Name = "ddlGroup";
            this.ddlGroup.Size = new System.Drawing.Size(98, 20);
            this.ddlGroup.TabIndex = 6;
            this.ddlGroup.SelectedIndexChanged += new System.EventHandler(this.ddlGroup_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "色彩";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "分组";
            // 
            // ddlColor
            // 
            this.ddlColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlColor.FormattingEnabled = true;
            this.ddlColor.Items.AddRange(new object[] {
            "8",
            "15",
            "16",
            "24",
            "32"});
            this.ddlColor.Location = new System.Drawing.Point(5, 99);
            this.ddlColor.Name = "ddlColor";
            this.ddlColor.Size = new System.Drawing.Size(98, 20);
            this.ddlColor.TabIndex = 9;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(557, 1080);
            this.MinimumSize = new System.Drawing.Size(557, 600);
            this.Name = "FormMain";
            this.Text = "远程桌面管理";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Open;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnBatOpen;
        private System.Windows.Forms.TextBox txtDesktopwidth;
        private System.Windows.Forms.TextBox txtDesktopheight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerIp;
        private System.Windows.Forms.DataGridViewButtonColumn btnOpen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerDomain;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerPassword;
        private System.Windows.Forms.ComboBox ddlGroup;
        private System.Windows.Forms.ComboBox ddlColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}


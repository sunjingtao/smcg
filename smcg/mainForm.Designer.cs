namespace smcg
{
    partial class mainForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableColumnsGrid = new System.Windows.Forms.DataGridView();
            this.nextBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.tableDataGridView = new System.Windows.Forms.DataGridView();
            this.tableSelectedStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCommentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableColumnsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.29147F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.70853F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableColumnsGrid, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.nextBtn, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.resetBtn, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableDataGridView, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.058824F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.94118F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(708, 452);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据库表选择：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 2);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(246, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(459, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "数据库字段设置：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableColumnsGrid
            // 
            this.tableColumnsGrid.AllowUserToAddRows = false;
            this.tableColumnsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableColumnsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.status,
            this.ColumnName,
            this.EntityName,
            this.ColumnCommentName});
            this.tableLayoutPanel1.SetColumnSpan(this.tableColumnsGrid, 2);
            this.tableColumnsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableColumnsGrid.Location = new System.Drawing.Point(246, 32);
            this.tableColumnsGrid.Name = "tableColumnsGrid";
            this.tableColumnsGrid.RowHeadersVisible = false;
            this.tableColumnsGrid.Size = new System.Drawing.Size(459, 381);
            this.tableColumnsGrid.TabIndex = 4;
            // 
            // nextBtn
            // 
            this.nextBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.nextBtn.Location = new System.Drawing.Point(630, 419);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 30);
            this.nextBtn.TabIndex = 2;
            this.nextBtn.Text = "下一步";
            this.nextBtn.UseVisualStyleBackColor = true;
            // 
            // resetBtn
            // 
            this.resetBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.resetBtn.Location = new System.Drawing.Point(540, 419);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 30);
            this.resetBtn.TabIndex = 5;
            this.resetBtn.Text = "重置";
            this.resetBtn.UseVisualStyleBackColor = true;
            // 
            // tableDataGridView
            // 
            this.tableDataGridView.AllowUserToAddRows = false;
            this.tableDataGridView.AllowUserToDeleteRows = false;
            this.tableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tableSelectedStatus,
            this.tableName});
            this.tableDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableDataGridView.Location = new System.Drawing.Point(3, 32);
            this.tableDataGridView.Name = "tableDataGridView";
            this.tableDataGridView.RowHeadersVisible = false;
            this.tableDataGridView.Size = new System.Drawing.Size(237, 381);
            this.tableDataGridView.TabIndex = 6;
            this.tableDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableDataGridView_CellClick);
            this.tableDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableDataGridView_CellValueChanged);
            // 
            // tableSelectedStatus
            // 
            this.tableSelectedStatus.DataPropertyName = "none";
            this.tableSelectedStatus.FalseValue = "false";
            this.tableSelectedStatus.HeaderText = "状态";
            this.tableSelectedStatus.Name = "tableSelectedStatus";
            this.tableSelectedStatus.TrueValue = "true";
            this.tableSelectedStatus.Width = 50;
            // 
            // tableName
            // 
            this.tableName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tableName.DataPropertyName = "Name";
            this.tableName.HeaderText = "表名";
            this.tableName.Name = "tableName";
            this.tableName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tableName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // status
            // 
            this.status.DataPropertyName = "Status";
            this.status.HeaderText = "状态";
            this.status.Name = "status";
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.status.Width = 60;
            // 
            // ColumnName
            // 
            this.ColumnName.DataPropertyName = "Name";
            this.ColumnName.HeaderText = "列名";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // EntityName
            // 
            this.EntityName.DataPropertyName = "EntityName";
            this.EntityName.HeaderText = "实体属性名";
            this.EntityName.Name = "EntityName";
            this.EntityName.Width = 120;
            // 
            // ColumnCommentName
            // 
            this.ColumnCommentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCommentName.DataPropertyName = "Comment";
            this.ColumnCommentName.HeaderText = "注释";
            this.ColumnCommentName.Name = "ColumnCommentName";
            this.ColumnCommentName.ReadOnly = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 452);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "mainForm";
            this.Text = "SpringMybatis代码生成器";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableColumnsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tableColumnsGrid;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.DataGridView tableDataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tableSelectedStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCommentName;


    }
}


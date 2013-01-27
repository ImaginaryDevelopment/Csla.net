namespace WinFormsUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.personEditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personEditBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.personEditBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.personEditGridControl = new DevExpress.XtraGrid.GridControl();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colId = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colId = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colIsActive = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colIsActive = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colRoleID = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colRoleID = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colUserName = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colUserName = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colPassword = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colPassword = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colFirstName = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colFirstName = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colMiddleName = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colMiddleName = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colLastName = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colLastName = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colDateLastUpdated = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colDateLastUpdated = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colUpdatedBy = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colUpdatedBy = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tbLoad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.personEditBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personEditBindingNavigator)).BeginInit();
            this.personEditBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personEditGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colIsActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colRoleID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colMiddleName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colDateLastUpdated)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colUpdatedBy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            this.SuspendLayout();
            // 
            // personEditBindingSource
            // 
            this.personEditBindingSource.DataSource = typeof(Library.Net.PersonEdit);
            // 
            // personEditBindingNavigator
            // 
            this.personEditBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.personEditBindingNavigator.BindingSource = this.personEditBindingSource;
            this.personEditBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.personEditBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.personEditBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.personEditBindingNavigatorSaveItem});
            this.personEditBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.personEditBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.personEditBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.personEditBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.personEditBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.personEditBindingNavigator.Name = "personEditBindingNavigator";
            this.personEditBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.personEditBindingNavigator.Size = new System.Drawing.Size(636, 25);
            this.personEditBindingNavigator.TabIndex = 0;
            this.personEditBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // personEditBindingNavigatorSaveItem
            // 
            this.personEditBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.personEditBindingNavigatorSaveItem.Enabled = false;
            this.personEditBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("personEditBindingNavigatorSaveItem.Image")));
            this.personEditBindingNavigatorSaveItem.Name = "personEditBindingNavigatorSaveItem";
            this.personEditBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.personEditBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // personEditGridControl
            // 
            this.personEditGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.personEditGridControl.DataSource = this.personEditBindingSource;
            this.personEditGridControl.Location = new System.Drawing.Point(0, 28);
            this.personEditGridControl.MainView = this.layoutView1;
            this.personEditGridControl.Name = "personEditGridControl";
            this.personEditGridControl.Size = new System.Drawing.Size(552, 389);
            this.personEditGridControl.TabIndex = 1;
            this.personEditGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1});
            // 
            // layoutView1
            // 
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colId,
            this.colIsActive,
            this.colRoleID,
            this.colUserName,
            this.colPassword,
            this.colFirstName,
            this.colMiddleName,
            this.colLastName,
            this.colDateLastUpdated,
            this.colUpdatedBy});
            this.layoutView1.GridControl = this.personEditGridControl;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.LayoutViewField = this.layoutViewField_colId;
            this.colId.Name = "colId";
            this.colId.OptionsColumn.ReadOnly = true;
            // 
            // layoutViewField_colId
            // 
            this.layoutViewField_colId.EditorPreferredWidth = 101;
            this.layoutViewField_colId.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colId.Name = "layoutViewField_colId";
            this.layoutViewField_colId.Size = new System.Drawing.Size(203, 20);
            this.layoutViewField_colId.TextSize = new System.Drawing.Size(94, 13);
            // 
            // colIsActive
            // 
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.LayoutViewField = this.layoutViewField_colIsActive;
            this.colIsActive.Name = "colIsActive";
            // 
            // layoutViewField_colIsActive
            // 
            this.layoutViewField_colIsActive.EditorPreferredWidth = 101;
            this.layoutViewField_colIsActive.Location = new System.Drawing.Point(0, 20);
            this.layoutViewField_colIsActive.Name = "layoutViewField_colIsActive";
            this.layoutViewField_colIsActive.Size = new System.Drawing.Size(203, 20);
            this.layoutViewField_colIsActive.TextSize = new System.Drawing.Size(94, 13);
            // 
            // colRoleID
            // 
            this.colRoleID.FieldName = "RoleID";
            this.colRoleID.LayoutViewField = this.layoutViewField_colRoleID;
            this.colRoleID.Name = "colRoleID";
            // 
            // layoutViewField_colRoleID
            // 
            this.layoutViewField_colRoleID.EditorPreferredWidth = 101;
            this.layoutViewField_colRoleID.Location = new System.Drawing.Point(0, 40);
            this.layoutViewField_colRoleID.Name = "layoutViewField_colRoleID";
            this.layoutViewField_colRoleID.Size = new System.Drawing.Size(203, 20);
            this.layoutViewField_colRoleID.TextSize = new System.Drawing.Size(94, 13);
            // 
            // colUserName
            // 
            this.colUserName.FieldName = "UserName";
            this.colUserName.LayoutViewField = this.layoutViewField_colUserName;
            this.colUserName.Name = "colUserName";
            // 
            // layoutViewField_colUserName
            // 
            this.layoutViewField_colUserName.EditorPreferredWidth = 101;
            this.layoutViewField_colUserName.Location = new System.Drawing.Point(0, 60);
            this.layoutViewField_colUserName.Name = "layoutViewField_colUserName";
            this.layoutViewField_colUserName.Size = new System.Drawing.Size(203, 20);
            this.layoutViewField_colUserName.TextSize = new System.Drawing.Size(94, 13);
            // 
            // colPassword
            // 
            this.colPassword.FieldName = "Password";
            this.colPassword.LayoutViewField = this.layoutViewField_colPassword;
            this.colPassword.Name = "colPassword";
            // 
            // layoutViewField_colPassword
            // 
            this.layoutViewField_colPassword.EditorPreferredWidth = 101;
            this.layoutViewField_colPassword.Location = new System.Drawing.Point(0, 80);
            this.layoutViewField_colPassword.Name = "layoutViewField_colPassword";
            this.layoutViewField_colPassword.Size = new System.Drawing.Size(203, 20);
            this.layoutViewField_colPassword.TextSize = new System.Drawing.Size(94, 13);
            // 
            // colFirstName
            // 
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.LayoutViewField = this.layoutViewField_colFirstName;
            this.colFirstName.Name = "colFirstName";
            // 
            // layoutViewField_colFirstName
            // 
            this.layoutViewField_colFirstName.EditorPreferredWidth = 101;
            this.layoutViewField_colFirstName.Location = new System.Drawing.Point(0, 100);
            this.layoutViewField_colFirstName.Name = "layoutViewField_colFirstName";
            this.layoutViewField_colFirstName.Size = new System.Drawing.Size(203, 20);
            this.layoutViewField_colFirstName.TextSize = new System.Drawing.Size(94, 13);
            // 
            // colMiddleName
            // 
            this.colMiddleName.FieldName = "MiddleName";
            this.colMiddleName.LayoutViewField = this.layoutViewField_colMiddleName;
            this.colMiddleName.Name = "colMiddleName";
            // 
            // layoutViewField_colMiddleName
            // 
            this.layoutViewField_colMiddleName.EditorPreferredWidth = 101;
            this.layoutViewField_colMiddleName.Location = new System.Drawing.Point(0, 120);
            this.layoutViewField_colMiddleName.Name = "layoutViewField_colMiddleName";
            this.layoutViewField_colMiddleName.Size = new System.Drawing.Size(203, 20);
            this.layoutViewField_colMiddleName.TextSize = new System.Drawing.Size(94, 13);
            // 
            // colLastName
            // 
            this.colLastName.FieldName = "LastName";
            this.colLastName.LayoutViewField = this.layoutViewField_colLastName;
            this.colLastName.Name = "colLastName";
            // 
            // layoutViewField_colLastName
            // 
            this.layoutViewField_colLastName.EditorPreferredWidth = 101;
            this.layoutViewField_colLastName.Location = new System.Drawing.Point(0, 140);
            this.layoutViewField_colLastName.Name = "layoutViewField_colLastName";
            this.layoutViewField_colLastName.Size = new System.Drawing.Size(203, 20);
            this.layoutViewField_colLastName.TextSize = new System.Drawing.Size(94, 13);
            // 
            // colDateLastUpdated
            // 
            this.colDateLastUpdated.FieldName = "DateLastUpdated";
            this.colDateLastUpdated.LayoutViewField = this.layoutViewField_colDateLastUpdated;
            this.colDateLastUpdated.Name = "colDateLastUpdated";
            // 
            // layoutViewField_colDateLastUpdated
            // 
            this.layoutViewField_colDateLastUpdated.EditorPreferredWidth = 101;
            this.layoutViewField_colDateLastUpdated.Location = new System.Drawing.Point(0, 160);
            this.layoutViewField_colDateLastUpdated.Name = "layoutViewField_colDateLastUpdated";
            this.layoutViewField_colDateLastUpdated.Size = new System.Drawing.Size(203, 20);
            this.layoutViewField_colDateLastUpdated.TextSize = new System.Drawing.Size(94, 13);
            // 
            // colUpdatedBy
            // 
            this.colUpdatedBy.FieldName = "UpdatedBy";
            this.colUpdatedBy.LayoutViewField = this.layoutViewField_colUpdatedBy;
            this.colUpdatedBy.Name = "colUpdatedBy";
            // 
            // layoutViewField_colUpdatedBy
            // 
            this.layoutViewField_colUpdatedBy.EditorPreferredWidth = 101;
            this.layoutViewField_colUpdatedBy.Location = new System.Drawing.Point(0, 180);
            this.layoutViewField_colUpdatedBy.Name = "layoutViewField_colUpdatedBy";
            this.layoutViewField_colUpdatedBy.Size = new System.Drawing.Size(203, 20);
            this.layoutViewField_colUpdatedBy.TextSize = new System.Drawing.Size(94, 13);
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colId,
            this.layoutViewField_colIsActive,
            this.layoutViewField_colRoleID,
            this.layoutViewField_colUserName,
            this.layoutViewField_colPassword,
            this.layoutViewField_colFirstName,
            this.layoutViewField_colMiddleName,
            this.layoutViewField_colLastName,
            this.layoutViewField_colDateLastUpdated,
            this.layoutViewField_colUpdatedBy});
            this.layoutViewCard1.Name = "layoutViewCard1";
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(561, 394);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load Person";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tbLoad
            // 
            this.tbLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLoad.Location = new System.Drawing.Point(558, 354);
            this.tbLoad.Name = "tbLoad";
            this.tbLoad.Size = new System.Drawing.Size(78, 20);
            this.tbLoad.TabIndex = 3;
            this.tbLoad.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 429);
            this.Controls.Add(this.tbLoad);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.personEditGridControl);
            this.Controls.Add(this.personEditBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.personEditBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personEditBindingNavigator)).EndInit();
            this.personEditBindingNavigator.ResumeLayout(false);
            this.personEditBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personEditGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colIsActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colRoleID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colMiddleName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colDateLastUpdated)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colUpdatedBy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource personEditBindingSource;
        private System.Windows.Forms.BindingNavigator personEditBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton personEditBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl personEditGridControl;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colId;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colId;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colIsActive;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colIsActive;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colRoleID;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colRoleID;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colUserName;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colUserName;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colPassword;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colPassword;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colFirstName;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colFirstName;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colMiddleName;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colMiddleName;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colLastName;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colLastName;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colDateLastUpdated;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colDateLastUpdated;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colUpdatedBy;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colUpdatedBy;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox tbLoad;
    }
}


namespace SpSofty.CodeGeneration.Core.Forms
{
    partial class TemplateManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplateManagerForm));
            this.gbTemplate = new System.Windows.Forms.GroupBox();
            this.gbTemplateNewStruture = new System.Windows.Forms.GroupBox();
            this.txtTemplateNewStruture = new System.Windows.Forms.TextBox();
            this.btnTemplateNewStruture = new System.Windows.Forms.Button();
            this.gbPhysicalPath = new System.Windows.Forms.GroupBox();
            this.txtPhysicalPath = new System.Windows.Forms.TextBox();
            this.btnCopyPhysicalPath = new System.Windows.Forms.Button();
            this.gbTemplateName = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tsTemplate = new System.Windows.Forms.ToolStrip();
            this.tsbTemplateAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbTemplateEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbTemplateRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbTemplateSave = new System.Windows.Forms.ToolStripButton();
            this.tsbTemplateCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbTemplateDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbValidateStructure = new System.Windows.Forms.ToolStripButton();
            this.gbRules = new System.Windows.Forms.GroupBox();
            this.gbRule = new System.Windows.Forms.GroupBox();
            this.gbRuleTargeProjectNamespace = new System.Windows.Forms.GroupBox();
            this.txtRuleTargeProjectNamespace = new System.Windows.Forms.TextBox();
            this.gbRuleFileEdit = new System.Windows.Forms.GroupBox();
            this.rtbRuleEditFile = new System.Windows.Forms.RichTextBox();
            this.gbRuleNamespace = new System.Windows.Forms.GroupBox();
            this.chkRuleKeep = new System.Windows.Forms.CheckBox();
            this.txtRuleNamespace = new System.Windows.Forms.TextBox();
            this.gbRuleFile = new System.Windows.Forms.GroupBox();
            this.btnRuleFile = new System.Windows.Forms.Button();
            this.txtRuleFile = new System.Windows.Forms.TextBox();
            this.gbRuleName = new System.Windows.Forms.GroupBox();
            this.txtRuleName = new System.Windows.Forms.TextBox();
            this.tsRule = new System.Windows.Forms.ToolStrip();
            this.tsbRuleAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbRuleEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRuleSave = new System.Windows.Forms.ToolStripButton();
            this.tsbRuleCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRuleDelete = new System.Windows.Forms.ToolStripButton();
            this.lbRules = new System.Windows.Forms.ListBox();
            this.gbTemplates = new System.Windows.Forms.GroupBox();
            this.tsTemplates = new System.Windows.Forms.ToolStrip();
            this.tsbTemplatesRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbTemplatesImport = new System.Windows.Forms.ToolStripButton();
            this.tsbTemplatesExport = new System.Windows.Forms.ToolStripButton();
            this.lbTemplates = new System.Windows.Forms.ListBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.gbTemplate.SuspendLayout();
            this.gbTemplateNewStruture.SuspendLayout();
            this.gbPhysicalPath.SuspendLayout();
            this.gbTemplateName.SuspendLayout();
            this.tsTemplate.SuspendLayout();
            this.gbRules.SuspendLayout();
            this.gbRule.SuspendLayout();
            this.gbRuleTargeProjectNamespace.SuspendLayout();
            this.gbRuleFileEdit.SuspendLayout();
            this.gbRuleNamespace.SuspendLayout();
            this.gbRuleFile.SuspendLayout();
            this.gbRuleName.SuspendLayout();
            this.tsRule.SuspendLayout();
            this.gbTemplates.SuspendLayout();
            this.tsTemplates.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTemplate
            // 
            this.gbTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTemplate.Controls.Add(this.gbTemplateNewStruture);
            this.gbTemplate.Controls.Add(this.gbPhysicalPath);
            this.gbTemplate.Controls.Add(this.gbTemplateName);
            this.gbTemplate.Controls.Add(this.tsTemplate);
            this.gbTemplate.Controls.Add(this.gbRules);
            this.gbTemplate.Location = new System.Drawing.Point(368, 12);
            this.gbTemplate.Name = "gbTemplate";
            this.gbTemplate.Size = new System.Drawing.Size(1011, 986);
            this.gbTemplate.TabIndex = 1;
            this.gbTemplate.TabStop = false;
            this.gbTemplate.Text = "Template";
            // 
            // gbTemplateNewStruture
            // 
            this.gbTemplateNewStruture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTemplateNewStruture.Controls.Add(this.txtTemplateNewStruture);
            this.gbTemplateNewStruture.Controls.Add(this.btnTemplateNewStruture);
            this.gbTemplateNewStruture.Location = new System.Drawing.Point(716, 62);
            this.gbTemplateNewStruture.Name = "gbTemplateNewStruture";
            this.gbTemplateNewStruture.Size = new System.Drawing.Size(289, 62);
            this.gbTemplateNewStruture.TabIndex = 9;
            this.gbTemplateNewStruture.TabStop = false;
            this.gbTemplateNewStruture.Text = "Create New Struture";
            // 
            // txtTemplateNewStruture
            // 
            this.txtTemplateNewStruture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTemplateNewStruture.Location = new System.Drawing.Point(6, 25);
            this.txtTemplateNewStruture.Name = "txtTemplateNewStruture";
            this.txtTemplateNewStruture.Size = new System.Drawing.Size(229, 26);
            this.txtTemplateNewStruture.TabIndex = 3;
            // 
            // btnTemplateNewStruture
            // 
            this.btnTemplateNewStruture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTemplateNewStruture.Image = ((System.Drawing.Image)(resources.GetObject("btnTemplateNewStruture.Image")));
            this.btnTemplateNewStruture.Location = new System.Drawing.Point(241, 22);
            this.btnTemplateNewStruture.Name = "btnTemplateNewStruture";
            this.btnTemplateNewStruture.Size = new System.Drawing.Size(40, 35);
            this.btnTemplateNewStruture.TabIndex = 4;
            this.btnTemplateNewStruture.UseVisualStyleBackColor = true;
            this.btnTemplateNewStruture.Click += new System.EventHandler(this.btnTemplateNewStruture_Click);
            // 
            // gbPhysicalPath
            // 
            this.gbPhysicalPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPhysicalPath.Controls.Add(this.txtPhysicalPath);
            this.gbPhysicalPath.Controls.Add(this.btnCopyPhysicalPath);
            this.gbPhysicalPath.Location = new System.Drawing.Point(302, 62);
            this.gbPhysicalPath.Name = "gbPhysicalPath";
            this.gbPhysicalPath.Size = new System.Drawing.Size(408, 62);
            this.gbPhysicalPath.TabIndex = 8;
            this.gbPhysicalPath.TabStop = false;
            this.gbPhysicalPath.Text = "Physical Path";
            // 
            // txtPhysicalPath
            // 
            this.txtPhysicalPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhysicalPath.Location = new System.Drawing.Point(6, 25);
            this.txtPhysicalPath.Name = "txtPhysicalPath";
            this.txtPhysicalPath.ReadOnly = true;
            this.txtPhysicalPath.Size = new System.Drawing.Size(348, 26);
            this.txtPhysicalPath.TabIndex = 3;
            // 
            // btnCopyPhysicalPath
            // 
            this.btnCopyPhysicalPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyPhysicalPath.Image = ((System.Drawing.Image)(resources.GetObject("btnCopyPhysicalPath.Image")));
            this.btnCopyPhysicalPath.Location = new System.Drawing.Point(360, 22);
            this.btnCopyPhysicalPath.Name = "btnCopyPhysicalPath";
            this.btnCopyPhysicalPath.Size = new System.Drawing.Size(40, 35);
            this.btnCopyPhysicalPath.TabIndex = 4;
            this.btnCopyPhysicalPath.UseVisualStyleBackColor = true;
            this.btnCopyPhysicalPath.Click += new System.EventHandler(this.btnCopyPhysicalPath_Click);
            // 
            // gbTemplateName
            // 
            this.gbTemplateName.Controls.Add(this.txtName);
            this.gbTemplateName.Location = new System.Drawing.Point(10, 62);
            this.gbTemplateName.Name = "gbTemplateName";
            this.gbTemplateName.Size = new System.Drawing.Size(286, 62);
            this.gbTemplateName.TabIndex = 7;
            this.gbTemplateName.TabStop = false;
            this.gbTemplateName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(8, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(272, 26);
            this.txtName.TabIndex = 1;
            this.txtName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyUp);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // tsTemplate
            // 
            this.tsTemplate.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsTemplate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbTemplateAdd,
            this.tsbTemplateEdit,
            this.tsbTemplateRefresh,
            this.toolStripSeparator4,
            this.tsbTemplateSave,
            this.tsbTemplateCancel,
            this.toolStripSeparator2,
            this.tsbTemplateDelete,
            this.toolStripSeparator3,
            this.tsbValidateStructure});
            this.tsTemplate.Location = new System.Drawing.Point(3, 22);
            this.tsTemplate.Name = "tsTemplate";
            this.tsTemplate.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tsTemplate.Size = new System.Drawing.Size(1005, 33);
            this.tsTemplate.TabIndex = 6;
            this.tsTemplate.Text = "toolStrip1";
            // 
            // tsbTemplateAdd
            // 
            this.tsbTemplateAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTemplateAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbTemplateAdd.Image")));
            this.tsbTemplateAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbTemplateAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTemplateAdd.Name = "tsbTemplateAdd";
            this.tsbTemplateAdd.Size = new System.Drawing.Size(34, 28);
            this.tsbTemplateAdd.Text = "Create Template";
            this.tsbTemplateAdd.Click += new System.EventHandler(this.tsbTemplateAdd_Click);
            // 
            // tsbTemplateEdit
            // 
            this.tsbTemplateEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTemplateEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbTemplateEdit.Image")));
            this.tsbTemplateEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbTemplateEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTemplateEdit.Name = "tsbTemplateEdit";
            this.tsbTemplateEdit.Size = new System.Drawing.Size(34, 28);
            this.tsbTemplateEdit.Text = "Edit Template";
            this.tsbTemplateEdit.Click += new System.EventHandler(this.tsbTemplateEdit_Click);
            // 
            // tsbTemplateRefresh
            // 
            this.tsbTemplateRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTemplateRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbTemplateRefresh.Image")));
            this.tsbTemplateRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbTemplateRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTemplateRefresh.Name = "tsbTemplateRefresh";
            this.tsbTemplateRefresh.Size = new System.Drawing.Size(34, 28);
            this.tsbTemplateRefresh.Text = "Refresh Template";
            this.tsbTemplateRefresh.Click += new System.EventHandler(this.tsbTemplateRefresh_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 33);
            // 
            // tsbTemplateSave
            // 
            this.tsbTemplateSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTemplateSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbTemplateSave.Image")));
            this.tsbTemplateSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbTemplateSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTemplateSave.Name = "tsbTemplateSave";
            this.tsbTemplateSave.Size = new System.Drawing.Size(34, 28);
            this.tsbTemplateSave.Text = "Save Template";
            this.tsbTemplateSave.Click += new System.EventHandler(this.tsbTemplateSave_Click);
            // 
            // tsbTemplateCancel
            // 
            this.tsbTemplateCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTemplateCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbTemplateCancel.Image")));
            this.tsbTemplateCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbTemplateCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTemplateCancel.Name = "tsbTemplateCancel";
            this.tsbTemplateCancel.Size = new System.Drawing.Size(34, 28);
            this.tsbTemplateCancel.Text = "Cancel Template";
            this.tsbTemplateCancel.Click += new System.EventHandler(this.tsbTemplateCancel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // tsbTemplateDelete
            // 
            this.tsbTemplateDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTemplateDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbTemplateDelete.Image")));
            this.tsbTemplateDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbTemplateDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTemplateDelete.Name = "tsbTemplateDelete";
            this.tsbTemplateDelete.Size = new System.Drawing.Size(34, 28);
            this.tsbTemplateDelete.Text = "Delete Template";
            this.tsbTemplateDelete.Click += new System.EventHandler(this.tsbTemplateDelete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 33);
            // 
            // tsbValidateStructure
            // 
            this.tsbValidateStructure.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbValidateStructure.Image = ((System.Drawing.Image)(resources.GetObject("tsbValidateStructure.Image")));
            this.tsbValidateStructure.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbValidateStructure.Name = "tsbValidateStructure";
            this.tsbValidateStructure.Size = new System.Drawing.Size(34, 28);
            this.tsbValidateStructure.Text = "Validate Structure";
            this.tsbValidateStructure.Click += new System.EventHandler(this.tsbValidatestructure_Click);
            // 
            // gbRules
            // 
            this.gbRules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRules.Controls.Add(this.gbRule);
            this.gbRules.Controls.Add(this.lbRules);
            this.gbRules.Location = new System.Drawing.Point(10, 129);
            this.gbRules.Name = "gbRules";
            this.gbRules.Size = new System.Drawing.Size(994, 848);
            this.gbRules.TabIndex = 5;
            this.gbRules.TabStop = false;
            this.gbRules.Text = "Template Rules";
            // 
            // gbRule
            // 
            this.gbRule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRule.Controls.Add(this.gbRuleTargeProjectNamespace);
            this.gbRule.Controls.Add(this.gbRuleFileEdit);
            this.gbRule.Controls.Add(this.gbRuleNamespace);
            this.gbRule.Controls.Add(this.gbRuleFile);
            this.gbRule.Controls.Add(this.gbRuleName);
            this.gbRule.Controls.Add(this.tsRule);
            this.gbRule.Location = new System.Drawing.Point(345, 25);
            this.gbRule.Name = "gbRule";
            this.gbRule.Size = new System.Drawing.Size(644, 817);
            this.gbRule.TabIndex = 2;
            this.gbRule.TabStop = false;
            this.gbRule.Text = "Rule";
            // 
            // gbRuleTargeProjectNamespace
            // 
            this.gbRuleTargeProjectNamespace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRuleTargeProjectNamespace.Controls.Add(this.txtRuleTargeProjectNamespace);
            this.gbRuleTargeProjectNamespace.Location = new System.Drawing.Point(6, 126);
            this.gbRuleTargeProjectNamespace.Name = "gbRuleTargeProjectNamespace";
            this.gbRuleTargeProjectNamespace.Size = new System.Drawing.Size(632, 62);
            this.gbRuleTargeProjectNamespace.TabIndex = 12;
            this.gbRuleTargeProjectNamespace.TabStop = false;
            this.gbRuleTargeProjectNamespace.Text = "Target Project (Namespace)";
            // 
            // txtRuleTargeProjectNamespace
            // 
            this.txtRuleTargeProjectNamespace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRuleTargeProjectNamespace.Location = new System.Drawing.Point(8, 25);
            this.txtRuleTargeProjectNamespace.Name = "txtRuleTargeProjectNamespace";
            this.txtRuleTargeProjectNamespace.Size = new System.Drawing.Size(618, 26);
            this.txtRuleTargeProjectNamespace.TabIndex = 1;
            // 
            // gbRuleFileEdit
            // 
            this.gbRuleFileEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRuleFileEdit.Controls.Add(this.rtbRuleEditFile);
            this.gbRuleFileEdit.Location = new System.Drawing.Point(6, 365);
            this.gbRuleFileEdit.Name = "gbRuleFileEdit";
            this.gbRuleFileEdit.Size = new System.Drawing.Size(632, 444);
            this.gbRuleFileEdit.TabIndex = 11;
            this.gbRuleFileEdit.TabStop = false;
            this.gbRuleFileEdit.Text = "Edit File";
            // 
            // rtbRuleEditFile
            // 
            this.rtbRuleEditFile.AcceptsTab = true;
            this.rtbRuleEditFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbRuleEditFile.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbRuleEditFile.Location = new System.Drawing.Point(6, 25);
            this.rtbRuleEditFile.Name = "rtbRuleEditFile";
            this.rtbRuleEditFile.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.rtbRuleEditFile.Size = new System.Drawing.Size(620, 414);
            this.rtbRuleEditFile.TabIndex = 0;
            this.rtbRuleEditFile.Text = "";
            this.rtbRuleEditFile.WordWrap = false;
            // 
            // gbRuleNamespace
            // 
            this.gbRuleNamespace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRuleNamespace.Controls.Add(this.chkRuleKeep);
            this.gbRuleNamespace.Controls.Add(this.txtRuleNamespace);
            this.gbRuleNamespace.Location = new System.Drawing.Point(6, 262);
            this.gbRuleNamespace.Name = "gbRuleNamespace";
            this.gbRuleNamespace.Size = new System.Drawing.Size(632, 97);
            this.gbRuleNamespace.TabIndex = 10;
            this.gbRuleNamespace.TabStop = false;
            this.gbRuleNamespace.Text = "Target Solution Path Rule";
            // 
            // chkRuleKeep
            // 
            this.chkRuleKeep.AutoSize = true;
            this.chkRuleKeep.Checked = true;
            this.chkRuleKeep.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRuleKeep.Location = new System.Drawing.Point(8, 63);
            this.chkRuleKeep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkRuleKeep.Name = "chkRuleKeep";
            this.chkRuleKeep.Size = new System.Drawing.Size(162, 24);
            this.chkRuleKeep.TabIndex = 2;
            this.chkRuleKeep.Text = "Keep existing file?";
            this.chkRuleKeep.UseVisualStyleBackColor = true;
            // 
            // txtRuleNamespace
            // 
            this.txtRuleNamespace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRuleNamespace.Location = new System.Drawing.Point(8, 25);
            this.txtRuleNamespace.Name = "txtRuleNamespace";
            this.txtRuleNamespace.Size = new System.Drawing.Size(616, 26);
            this.txtRuleNamespace.TabIndex = 1;
            // 
            // gbRuleFile
            // 
            this.gbRuleFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRuleFile.Controls.Add(this.btnRuleFile);
            this.gbRuleFile.Controls.Add(this.txtRuleFile);
            this.gbRuleFile.Location = new System.Drawing.Point(6, 58);
            this.gbRuleFile.Name = "gbRuleFile";
            this.gbRuleFile.Size = new System.Drawing.Size(632, 62);
            this.gbRuleFile.TabIndex = 9;
            this.gbRuleFile.TabStop = false;
            this.gbRuleFile.Text = "File Template";
            // 
            // btnRuleFile
            // 
            this.btnRuleFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRuleFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRuleFile.Location = new System.Drawing.Point(585, 22);
            this.btnRuleFile.Name = "btnRuleFile";
            this.btnRuleFile.Size = new System.Drawing.Size(40, 35);
            this.btnRuleFile.TabIndex = 5;
            this.btnRuleFile.Text = "...";
            this.btnRuleFile.UseVisualStyleBackColor = true;
            this.btnRuleFile.Click += new System.EventHandler(this.btnRuleFile_Click);
            // 
            // txtRuleFile
            // 
            this.txtRuleFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRuleFile.Location = new System.Drawing.Point(8, 25);
            this.txtRuleFile.Name = "txtRuleFile";
            this.txtRuleFile.ReadOnly = true;
            this.txtRuleFile.Size = new System.Drawing.Size(571, 26);
            this.txtRuleFile.TabIndex = 1;
            // 
            // gbRuleName
            // 
            this.gbRuleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRuleName.Controls.Add(this.txtRuleName);
            this.gbRuleName.Location = new System.Drawing.Point(6, 194);
            this.gbRuleName.Name = "gbRuleName";
            this.gbRuleName.Size = new System.Drawing.Size(632, 62);
            this.gbRuleName.TabIndex = 8;
            this.gbRuleName.TabStop = false;
            this.gbRuleName.Text = "Target File Rule";
            // 
            // txtRuleName
            // 
            this.txtRuleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRuleName.Location = new System.Drawing.Point(8, 25);
            this.txtRuleName.Name = "txtRuleName";
            this.txtRuleName.Size = new System.Drawing.Size(618, 26);
            this.txtRuleName.TabIndex = 1;
            // 
            // tsRule
            // 
            this.tsRule.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsRule.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRuleAdd,
            this.tsbRuleEdit,
            this.toolStripSeparator5,
            this.tsbRuleSave,
            this.tsbRuleCancel,
            this.toolStripSeparator1,
            this.tsbRuleDelete});
            this.tsRule.Location = new System.Drawing.Point(3, 22);
            this.tsRule.Name = "tsRule";
            this.tsRule.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tsRule.Size = new System.Drawing.Size(638, 25);
            this.tsRule.TabIndex = 0;
            this.tsRule.Text = "toolStrip1";
            // 
            // tsbRuleAdd
            // 
            this.tsbRuleAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRuleAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbRuleAdd.Image")));
            this.tsbRuleAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRuleAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRuleAdd.Name = "tsbRuleAdd";
            this.tsbRuleAdd.Size = new System.Drawing.Size(34, 20);
            this.tsbRuleAdd.Text = "Create Rule";
            this.tsbRuleAdd.Click += new System.EventHandler(this.tsbRuleAdd_Click);
            // 
            // tsbRuleEdit
            // 
            this.tsbRuleEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRuleEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbRuleEdit.Image")));
            this.tsbRuleEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRuleEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRuleEdit.Name = "tsbRuleEdit";
            this.tsbRuleEdit.Size = new System.Drawing.Size(34, 20);
            this.tsbRuleEdit.Text = "Edit Rule";
            this.tsbRuleEdit.Click += new System.EventHandler(this.tsbRuleEdit_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRuleSave
            // 
            this.tsbRuleSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRuleSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbRuleSave.Image")));
            this.tsbRuleSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRuleSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRuleSave.Name = "tsbRuleSave";
            this.tsbRuleSave.Size = new System.Drawing.Size(34, 20);
            this.tsbRuleSave.Text = "Save Rule";
            this.tsbRuleSave.Click += new System.EventHandler(this.tsbRuleSave_Click);
            // 
            // tsbRuleCancel
            // 
            this.tsbRuleCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRuleCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbRuleCancel.Image")));
            this.tsbRuleCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRuleCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRuleCancel.Name = "tsbRuleCancel";
            this.tsbRuleCancel.Size = new System.Drawing.Size(34, 20);
            this.tsbRuleCancel.Text = "Cancel Rule";
            this.tsbRuleCancel.Click += new System.EventHandler(this.tsbRuleCancel_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRuleDelete
            // 
            this.tsbRuleDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRuleDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbRuleDelete.Image")));
            this.tsbRuleDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRuleDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRuleDelete.Name = "tsbRuleDelete";
            this.tsbRuleDelete.Size = new System.Drawing.Size(34, 20);
            this.tsbRuleDelete.Text = "Delete Rule";
            this.tsbRuleDelete.Click += new System.EventHandler(this.tsbRuleDelete_Click);
            // 
            // lbRules
            // 
            this.lbRules.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbRules.FormattingEnabled = true;
            this.lbRules.HorizontalScrollbar = true;
            this.lbRules.ItemHeight = 20;
            this.lbRules.Location = new System.Drawing.Point(6, 25);
            this.lbRules.Name = "lbRules";
            this.lbRules.Size = new System.Drawing.Size(332, 764);
            this.lbRules.TabIndex = 1;
            this.lbRules.SelectedValueChanged += new System.EventHandler(this.lbRules_SelectedValueChanged);
            // 
            // gbTemplates
            // 
            this.gbTemplates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbTemplates.Controls.Add(this.tsTemplates);
            this.gbTemplates.Controls.Add(this.lbTemplates);
            this.gbTemplates.Location = new System.Drawing.Point(12, 12);
            this.gbTemplates.Name = "gbTemplates";
            this.gbTemplates.Size = new System.Drawing.Size(350, 986);
            this.gbTemplates.TabIndex = 4;
            this.gbTemplates.TabStop = false;
            this.gbTemplates.Text = "Current Templates";
            // 
            // tsTemplates
            // 
            this.tsTemplates.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsTemplates.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbTemplatesRefresh,
            this.toolStripSeparator6,
            this.tsbTemplatesImport,
            this.tsbTemplatesExport});
            this.tsTemplates.Location = new System.Drawing.Point(3, 22);
            this.tsTemplates.Name = "tsTemplates";
            this.tsTemplates.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tsTemplates.Size = new System.Drawing.Size(344, 25);
            this.tsTemplates.TabIndex = 1;
            this.tsTemplates.Text = "toolStrip1";
            // 
            // tsbTemplatesRefresh
            // 
            this.tsbTemplatesRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTemplatesRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbTemplatesRefresh.Image")));
            this.tsbTemplatesRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbTemplatesRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTemplatesRefresh.Name = "tsbTemplatesRefresh";
            this.tsbTemplatesRefresh.Size = new System.Drawing.Size(34, 20);
            this.tsbTemplatesRefresh.Text = "Refresh Templates";
            this.tsbTemplatesRefresh.Click += new System.EventHandler(this.tsbTemplatesRefresh_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbTemplatesImport
            // 
            this.tsbTemplatesImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTemplatesImport.Image = ((System.Drawing.Image)(resources.GetObject("tsbTemplatesImport.Image")));
            this.tsbTemplatesImport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbTemplatesImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTemplatesImport.Name = "tsbTemplatesImport";
            this.tsbTemplatesImport.Size = new System.Drawing.Size(34, 20);
            this.tsbTemplatesImport.Text = "Import Templates";
            this.tsbTemplatesImport.Click += new System.EventHandler(this.tsbTemplatesImport_Click);
            // 
            // tsbTemplatesExport
            // 
            this.tsbTemplatesExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTemplatesExport.Image = ((System.Drawing.Image)(resources.GetObject("tsbTemplatesExport.Image")));
            this.tsbTemplatesExport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbTemplatesExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTemplatesExport.Name = "tsbTemplatesExport";
            this.tsbTemplatesExport.Size = new System.Drawing.Size(34, 20);
            this.tsbTemplatesExport.Text = "Export Templates";
            this.tsbTemplatesExport.Click += new System.EventHandler(this.tsbTemplatesExport_Click);
            // 
            // lbTemplates
            // 
            this.lbTemplates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTemplates.FormattingEnabled = true;
            this.lbTemplates.HorizontalScrollbar = true;
            this.lbTemplates.ItemHeight = 20;
            this.lbTemplates.Location = new System.Drawing.Point(10, 85);
            this.lbTemplates.Name = "lbTemplates";
            this.lbTemplates.Size = new System.Drawing.Size(332, 864);
            this.lbTemplates.TabIndex = 0;
            this.lbTemplates.SelectedValueChanged += new System.EventHandler(this.lbTemplates_SelectedValueChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 1011);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.statusStrip.Size = new System.Drawing.Size(1390, 32);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(79, 25);
            this.lblStatus.Text = "lblStatus";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // TemplateManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 1043);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.gbTemplates);
            this.Controls.Add(this.gbTemplate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "TemplateManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: Template Manager ::";
            this.TopMost = true;
            this.gbTemplate.ResumeLayout(false);
            this.gbTemplate.PerformLayout();
            this.gbTemplateNewStruture.ResumeLayout(false);
            this.gbTemplateNewStruture.PerformLayout();
            this.gbPhysicalPath.ResumeLayout(false);
            this.gbPhysicalPath.PerformLayout();
            this.gbTemplateName.ResumeLayout(false);
            this.gbTemplateName.PerformLayout();
            this.tsTemplate.ResumeLayout(false);
            this.tsTemplate.PerformLayout();
            this.gbRules.ResumeLayout(false);
            this.gbRule.ResumeLayout(false);
            this.gbRule.PerformLayout();
            this.gbRuleTargeProjectNamespace.ResumeLayout(false);
            this.gbRuleTargeProjectNamespace.PerformLayout();
            this.gbRuleFileEdit.ResumeLayout(false);
            this.gbRuleNamespace.ResumeLayout(false);
            this.gbRuleNamespace.PerformLayout();
            this.gbRuleFile.ResumeLayout(false);
            this.gbRuleFile.PerformLayout();
            this.gbRuleName.ResumeLayout(false);
            this.gbRuleName.PerformLayout();
            this.tsRule.ResumeLayout(false);
            this.tsRule.PerformLayout();
            this.gbTemplates.ResumeLayout(false);
            this.gbTemplates.PerformLayout();
            this.tsTemplates.ResumeLayout(false);
            this.tsTemplates.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbTemplate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhysicalPath;
        private System.Windows.Forms.GroupBox gbTemplates;
        private System.Windows.Forms.ListBox lbTemplates;
        private System.Windows.Forms.Button btnCopyPhysicalPath;
        private System.Windows.Forms.GroupBox gbRules;
        private System.Windows.Forms.ToolStrip tsTemplate;
        private System.Windows.Forms.GroupBox gbRule;
        private System.Windows.Forms.ToolStrip tsRule;
        private System.Windows.Forms.ListBox lbRules;
        private System.Windows.Forms.ToolStripButton tsbTemplateAdd;
        private System.Windows.Forms.ToolStripButton tsbRuleAdd;
        private System.Windows.Forms.ToolStripButton tsbRuleEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbRuleDelete;
        private System.Windows.Forms.ToolStripButton tsbTemplateEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbTemplateDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStrip tsTemplates;
        private System.Windows.Forms.ToolStripButton tsbTemplatesImport;
        private System.Windows.Forms.ToolStripButton tsbTemplatesExport;
        private System.Windows.Forms.GroupBox gbPhysicalPath;
        private System.Windows.Forms.GroupBox gbTemplateName;
        private System.Windows.Forms.GroupBox gbRuleName;
        private System.Windows.Forms.TextBox txtRuleName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbTemplateSave;
        private System.Windows.Forms.GroupBox gbRuleNamespace;
        private System.Windows.Forms.TextBox txtRuleNamespace;
        private System.Windows.Forms.GroupBox gbRuleFile;
        private System.Windows.Forms.Button btnRuleFile;
        private System.Windows.Forms.TextBox txtRuleFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbRuleSave;
        private System.Windows.Forms.GroupBox gbRuleFileEdit;
        private System.Windows.Forms.RichTextBox rtbRuleEditFile;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripButton tsbTemplatesRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbTemplateRefresh;
        private System.Windows.Forms.ToolStripButton tsbTemplateCancel;
        private System.Windows.Forms.ToolStripButton tsbRuleCancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.CheckBox chkRuleKeep;
        private System.Windows.Forms.GroupBox gbRuleTargeProjectNamespace;
        private System.Windows.Forms.TextBox txtRuleTargeProjectNamespace;
        private System.Windows.Forms.ToolStripButton tsbValidateStructure;
        private System.Windows.Forms.GroupBox gbTemplateNewStruture;
        private System.Windows.Forms.TextBox txtTemplateNewStruture;
        private System.Windows.Forms.Button btnTemplateNewStruture;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}
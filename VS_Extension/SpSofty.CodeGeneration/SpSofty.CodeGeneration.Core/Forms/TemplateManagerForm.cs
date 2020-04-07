using SpSofty.CodeGeneration.Core.Cores;
using SpSofty.CodeGeneration.Core.Enuns;
using SpSofty.CodeGeneration.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpSofty.CodeGeneration.Core.Forms
{
    public partial class TemplateManagerForm : Form
    {
        private readonly Configuration configuration;
        private readonly TemplateCore templateCore;
        private string titleGbRules;
        private string titleGbTemplates;
        private bool isEditRule;

        public TemplateManagerForm(Configuration configuration)
        {
            this.configuration = configuration;
            templateCore = new TemplateCore(this.configuration);

            InitializeComponent();
            Initialize();
        }

        #region Private Method
        private void Initialize()
        {
            WriteStatus("Welcome to the code generation manager.");
            tsbTemplateEdit.Visible = false;
            tsbTemplateRefresh.Visible = false;

            titleGbTemplates = gbTemplates.Text;
            titleGbRules = gbRules.Text;

            gbTemplateName.Enabled = false;
            gbPhysicalPath.Enabled = false;
            gbRules.Enabled = false;

            AddTemplatesInListBox();

            ScrenTemplateControl(EnScrenTemplateControl.Default);
        }

        private void AddTemplatesInListBox()
        {
            lbTemplates.Items.Clear();
            templateCore.Templates.OrderBy(t => t.Name).ToList()
                .ForEach(t => lbTemplates.Items.Add(t.Name));

            gbTemplates.Text = string.Concat(titleGbTemplates, lbTemplates.Items.Count == 0 ? string.Empty : $" - Count: {lbTemplates.Items.Count}");
        }

        private void AddRuleInListBox(string templateName)
        {
            lbRules.Items.Clear();
            Template template = templateCore.Templates
                .FirstOrDefault(t => t.Name.Equals(templateName));

            if (template != null)
            {
                template.TemplateRules.ToList()
                    .ForEach(t => lbRules.Items.Add(t.Name));
            }

            gbRules.Text = string.Concat(titleGbRules, lbRules.Items.Count == 0 ? string.Empty : $" - Count: {lbRules.Items.Count}");
        }

        private void ScrenTemplateControl(EnScrenTemplateControl enTamlateViewButton)
        {
            tsbTemplateAdd.Enabled = false;
            tsbTemplateEdit.Enabled = false;
            tsbTemplateRefresh.Enabled = false;
            tsbTemplateSave.Enabled = false;
            tsbTemplateCancel.Enabled = false;
            tsbTemplateDelete.Enabled = false;
            tsbValidateStructure.Enabled = false;

            gbTemplates.Enabled = false;
            gbTemplateName.Enabled = false;
            gbPhysicalPath.Enabled = false;
            gbRules.Enabled = false;
            gbTemplateNewStruture.Enabled = false;

            btnCopyPhysicalPath.Enabled = false;

            switch (enTamlateViewButton)
            {
                case EnScrenTemplateControl.Default:
                    tsbTemplateAdd.Enabled = true;

                    gbTemplates.Enabled = true;
                    break;
                case EnScrenTemplateControl.Add:
                    tsbTemplateSave.Enabled = true;
                    tsbTemplateCancel.Enabled = true;

                    gbTemplateName.Enabled = true;
                    gbPhysicalPath.Enabled = true;
                    btnCopyPhysicalPath.Enabled = true;

                    txtName.ReadOnly = false;
                    ClearScrenTeplate();
                    break;
                case EnScrenTemplateControl.Edit:
                    tsbTemplateSave.Enabled = true;
                    tsbTemplateCancel.Enabled = true;

                    gbTemplateName.Enabled = true;
                    gbPhysicalPath.Enabled = true;
                    gbRules.Enabled = true;
                    btnCopyPhysicalPath.Enabled = true;

                    txtName.ReadOnly = false;
                    break;
                case EnScrenTemplateControl.Template:
                    tsbTemplateAdd.Enabled = true;
                    tsbTemplateEdit.Enabled = true;
                    tsbTemplateDelete.Enabled = true;
                    tsbValidateStructure.Enabled = true;

                    gbTemplates.Enabled = true;
                    gbTemplateName.Enabled = true;
                    gbPhysicalPath.Enabled = true;
                    gbRules.Enabled = true;
                    gbTemplateNewStruture.Enabled = true;
                    btnCopyPhysicalPath.Enabled = true;

                    txtName.ReadOnly = true;
                    break;
            }
        }

        private void ScrenRuleControl(EnScrenRuleControl enTamlateViewButton)
        {
            tsTemplate.Enabled = true;
            tsbRuleAdd.Enabled = false;
            tsbRuleEdit.Enabled = false;
            tsbRuleSave.Enabled = false;
            tsbRuleCancel.Enabled = false;
            tsbRuleDelete.Enabled = false;

            gbTemplates.Enabled = false;
            gbRuleFile.Enabled = false;
            gbRuleTargeProjectNamespace.Enabled = false;
            gbRuleName.Enabled = false;
            gbRuleNamespace.Enabled = false;
            gbRuleFileEdit.Enabled = false;

            btnTemplateNewStruture.Enabled = false;
            lbRules.Enabled = false;
            btnRuleFile.Enabled = false;
            txtRuleTargeProjectNamespace.ReadOnly = true;
            txtRuleName.ReadOnly = true;
            txtRuleNamespace.ReadOnly = true;
            rtbRuleEditFile.ReadOnly = true;

            switch (enTamlateViewButton)
            {
                case EnScrenRuleControl.Default:
                    lbRules.Enabled = true;
                    tsbRuleAdd.Enabled = true;

                    btnTemplateNewStruture.Enabled = true;
                    gbTemplates.Enabled = true;
                    break;
                case EnScrenRuleControl.Add:
                    tsTemplate.Enabled = false;
                    tsbRuleSave.Enabled = true;
                    tsbRuleCancel.Enabled = true;

                    gbRuleFile.Enabled = true;
                    gbRuleTargeProjectNamespace.Enabled = true;
                    gbRuleName.Enabled = true;
                    gbRuleNamespace.Enabled = true;
                    gbRuleFileEdit.Enabled = true;

                    btnRuleFile.Enabled = true;
                    txtRuleTargeProjectNamespace.ReadOnly = false;
                    txtRuleName.ReadOnly = false;
                    txtRuleNamespace.ReadOnly = false;
                    rtbRuleEditFile.ReadOnly = false;

                    ClearScrenRule();
                    break;
                case EnScrenRuleControl.Edit:
                    tsTemplate.Enabled = false;
                    tsbRuleSave.Enabled = true;
                    tsbRuleCancel.Enabled = true;

                    gbRuleFile.Enabled = true;
                    gbRuleTargeProjectNamespace.Enabled = true;
                    txtRuleTargeProjectNamespace.ReadOnly = false;
                    gbRuleName.Enabled = true;
                    gbRuleNamespace.Enabled = true;
                    gbRuleFileEdit.Enabled = true;
                    
                    txtRuleName.ReadOnly = false;
                    txtRuleNamespace.ReadOnly = false;
                    rtbRuleEditFile.ReadOnly = false;
                    break;
                case EnScrenRuleControl.Rule:
                    lbRules.Enabled = true;
                    tsbRuleAdd.Enabled = true;
                    gbRuleTargeProjectNamespace.Enabled = true;
                    tsbRuleEdit.Enabled = true;
                    tsbRuleDelete.Enabled = true;

                    btnTemplateNewStruture.Enabled = true;
                    gbTemplates.Enabled = true;
                    break;
            }
        }

        private void ClearScrenTeplate()
        {
            txtName.Text = string.Empty;
            txtPhysicalPath.Text = string.Empty;
            txtTemplateNewStruture.Text = string.Empty;

            lbRules.Items.Clear();

            ClearScrenRule();
        }

        private void ClearScrenRule()
        {
            txtRuleFile.Text = string.Empty;
            txtRuleTargeProjectNamespace.Text = string.Empty;
            txtRuleName.Text = string.Empty;
            txtRuleNamespace.Text = string.Empty;
            rtbRuleEditFile.Text = string.Empty;
        }

        private void WriteStatus(string message)
        {
            lblStatus.Text = message;
        }

        private void ImportTemplates(string fileImporteTemplates)
        {
            try
            {
                templateCore.Imporetes(fileImporteTemplates);
                AddTemplatesInListBox();
            }
            catch (Exception ex)
            {
                WriteStatus($"Importing new templates generated an error: {ex.Message}");
            }
        }

        private void PrepareRuleFile(string fullName)
        {
            string fileName = templateCore.GetFileName(fullName);
            string namespaceClass = templateCore.GetNamespace(fullName);
            KeyValuePair<string, string> targetAndProjectNamespace = templateCore.NamespaceToTargetAndProjectNamespace(namespaceClass, fullName);

            txtRuleFile.Text = fullName;
            txtRuleTargeProjectNamespace.Text = targetAndProjectNamespace.Value;
            txtRuleName.Text = templateCore.PrepareRuleName(fileName);
            txtRuleNamespace.Text = targetAndProjectNamespace.Key;
            string contetFile = templateCore.PrepareEditFile(fileName,
                targetAndProjectNamespace.Value, fullName);
            SetRichTextBox(contetFile);
        }

        #region RuleEditFile
        private void SetRichTextBox(string contentFile)
        {
            rtbRuleEditFile.Clear();

            var regex = new System.Text.RegularExpressions.Regex(Environment.NewLine);
            String[] lines = regex.Split(contentFile);

            foreach (string l in lines)
            {
                ParseLine(l);
            }
        }

        private void ParseLine(string line)
        {
            var r = new System.Text.RegularExpressions.Regex("([ \\t{}():;\\.\\n])");
            String[] tokens = r.Split(line);
            foreach (string token in tokens)
            {
                string currentToken = token.Replace(Environment.NewLine, "");

                // Set the tokens default color and font.  
                rtbRuleEditFile.SelectionColor = Color.Black;
                rtbRuleEditFile.SelectionFont = new Font("Courier New", 10, FontStyle.Regular);
                // Check whether the token is a keyword.   
                String[] keywords = { "public", "void", "using", "static", "class", "interface", "const",
                    "namespace", "virtual",
                    "int", "String", "string", "float", "long", "double" };

                for (int i = 0; i < keywords.Length; i++)
                {
                    if (keywords[i] == currentToken)
                    {
                        // Apply alternative color and font to highlight keyword.  
                        rtbRuleEditFile.SelectionColor = Color.Blue;
                        rtbRuleEditFile.SelectionFont = new Font("Courier New", 10, FontStyle.Bold);
                        break;
                    }
                }

                String[] keywordInternal = { Constants.Tokens.SAFE_NAME, Constants.Tokens.SAFE_NAME_LOWER, Constants.Tokens.ROOT_NAMESPACE };
                for (int i = 0; i < keywordInternal.Length; i++)
                {
                    if (keywordInternal[i] == currentToken)
                    {
                        // Apply alternative color and font to highlight keyword.  
                        rtbRuleEditFile.SelectionColor = Color.DarkGray;
                        rtbRuleEditFile.SelectionFont = new Font("Courier New", 10, FontStyle.Bold);
                        break;
                    }
                }

                rtbRuleEditFile.SelectedText = token;
            }
            rtbRuleEditFile.SelectedText = "\n";
        }
        #endregion
        #endregion

        #region Events

        #region Click - Templates
        private void tsbTemplatesRefresh_Click(object sender, EventArgs e)
        {
            WriteStatus("Refresh All Templates");

            templateCore.ReloadTemplates();
            AddTemplatesInListBox();
            ScrenTemplateControl(EnScrenTemplateControl.Default);
            ClearScrenTeplate();
        }

        private void tsbTemplatesImport_Click(object sender, EventArgs e)
        {
            string fileImporteTemplates;
            WriteStatus("Import of new templates");

            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                // Filter by All Files
                dlg.Filter = "Zip |*.zip";
                dlg.Multiselect = false;
                dlg.InitialDirectory = configuration.PhysicalPathTemplate;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    fileImporteTemplates = dlg.FileName;
                    WriteStatus($"Importing new templates from the file: {System.IO.Path.GetFileName(fileImporteTemplates)}");
                    ImportTemplates(fileImporteTemplates);
                    ScrenTemplateControl(EnScrenTemplateControl.Default);
                    ClearScrenTeplate();
                }
                else
                {
                    WriteStatus("Import of new templates has been canceled");
                }
            }

        }

        private void tsbTemplatesExport_Click(object sender, EventArgs e)
        {
            WriteStatus("Export all templates");

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {

                saveFileDialog.Filter = "Zip |*.zip";
                saveFileDialog.FileName = $"{System.IO.Path.GetFileNameWithoutExtension(configuration.ConfigurationFile)}_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.zip";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    templateCore.ExportTemplates(saveFileDialog.FileName);
                }
            }
        }
        #endregion

        #region Click - Template
        private void tsbTemplateAdd_Click(object sender, EventArgs e)
        {
            ScrenTemplateControl(EnScrenTemplateControl.Add);
            ScrenRuleControl(EnScrenRuleControl.Default);

            txtPhysicalPath.Text = configuration.PhysicalPathTemplate;

            WriteStatus("Create new template");
        }

        private void tsbTemplateEdit_Click(object sender, EventArgs e)
        {
            ScrenTemplateControl(EnScrenTemplateControl.Edit);
            ScrenRuleControl(EnScrenRuleControl.Default);

            WriteStatus($"Edit template: {txtName.Text}");
        }

        private void tsbTemplateRefresh_Click(object sender, EventArgs e)
        {
            WriteStatus($"Refresh template: {txtName.Text}");

            ScrenTemplateControl(EnScrenTemplateControl.Default);
            ScrenRuleControl(EnScrenRuleControl.Default);
        }

        private void tsbTemplateSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text.Trim();

                if (string.IsNullOrEmpty(name))
                {
                    WriteStatus("Template 'Name' cannot be empty.");
                    return;
                }

                if (templateCore.Exists(name))
                {
                    WriteStatus("There is already a template with that name.");
                    return;
                }

                Template template = new Template
                {
                    Name = name,
                    PhysicalPath = System.IO.Path.Combine(configuration.PhysicalPathTemplate, name)
                };

                templateCore.CreateTemplate(template);

                AddTemplatesInListBox();
                ScrenTemplateControl(EnScrenTemplateControl.Default);
                ScrenRuleControl(EnScrenRuleControl.Default);
                WriteStatus("Saved template");
            }
            catch (Exception ex)
            {
                WriteStatus($"Error trying to save template: {ex.Message}");
            }
        }

        private void tsbTemplateCancel_Click(object sender, EventArgs e)
        {
            ScrenTemplateControl(EnScrenTemplateControl.Default);
            ScrenRuleControl(EnScrenRuleControl.Default);

            WriteStatus("Canceled");
        }

        private void tsbTemplateDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text.Trim();

                if (string.IsNullOrEmpty(name))
                {
                    WriteStatus("Template 'Name' cannot be empty.");
                    return;
                }

                templateCore.DeleteTemplate(name);

                ScrenTemplateControl(EnScrenTemplateControl.Default);
                ScrenRuleControl(EnScrenRuleControl.Default);
                WriteStatus("Deleted template");
                AddTemplatesInListBox();
            }
            catch (Exception ex)
            {
                WriteStatus($"Error trying to delete template: {ex.Message}");
            }
        }

        private void btnCopyPhysicalPath_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtPhysicalPath.Text, TextDataFormat.Text);
        }

        private void btnTemplateNewStruture_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTemplateNewStruture.Text))
            {
                WriteStatus("Template 'Create New Struture' cannot be empty.");
                return;
            }

            Template template = templateCore.GetTemplate(txtName.Text);
            templateCore.CreateNewFile(txtTemplateNewStruture.Text, template);

            WriteStatus($"Create new struture '{txtTemplateNewStruture.Text}' with success");
            MessageBox.Show("New structure creation process completed.");
        }

        private void tsbValidatestructure_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                WriteStatus("Template 'Name' cannot be empty.");
                return;
            }

            int count = templateCore.ValidateStructure(txtName.Text);
            WriteStatus($"Total files created during structure check: {count}");
            MessageBox.Show("Structure validation process completed.");
        }
        #endregion

        #region Click - Rule
        private void tsbRuleAdd_Click(object sender, EventArgs e)
        {
            isEditRule = false;
            ScrenRuleControl(EnScrenRuleControl.Add);

            WriteStatus($"Create new rule in the '{txtName.Text}' template");
        }

        private void tsbRuleEdit_Click(object sender, EventArgs e)
        {
            isEditRule = true;
            ScrenRuleControl(EnScrenRuleControl.Edit);

            WriteStatus($"Edit the '{txtName.Text}' rule from the '{txtRuleName.Text}' template");
        }

        private void tsbRuleSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtRuleFile.Text))
                {
                    WriteStatus("Input 'File Template' cannot be empty.");
                    return;
                }

                if (string.IsNullOrEmpty(txtRuleTargeProjectNamespace.Text))
                {
                    WriteStatus("Input 'Target Project Namespace' cannot be empty.");
                    return;
                }

                if (string.IsNullOrEmpty(txtRuleName.Text))
                {
                    WriteStatus("Input 'Target File Rule' cannot be empty.");
                    return;
                }

                string templateName = txtName.Text;
                TemplateRule templateRule = new TemplateRule
                {
                    File = templateCore.CreateFileRulePath(templateName, txtRuleFile.Text),
                    TargeNamespace = txtRuleTargeProjectNamespace.Text,
                    Target = txtRuleName.Text,
                    DestinationPath = txtRuleNamespace.Text,
                    Overide = !chkRuleKeep.Checked
                };

                string contentFile = rtbRuleEditFile.Text;
                if (isEditRule)
                {
                    templateCore.EditRule(templateName, templateRule, contentFile);
                }
                else
                {
                    templateCore.CreateRule(templateName, templateRule, contentFile);
                }

                AddRuleInListBox(templateName);
                WriteStatus($"Save the '{txtName.Text}' rule from the '{txtRuleName.Text}' template");
                ScrenRuleControl(EnScrenRuleControl.Default);
                ClearScrenRule();
            }
            catch (Exception ex)
            {
                WriteStatus($"Error trying to delete rule: {ex.Message}");
            }
        }

        private void tsbRuleCancel_Click(object sender, EventArgs e)
        {
            ScrenRuleControl(EnScrenRuleControl.Default);

            WriteStatus("Canceled");
        }

        private void tsbRuleDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtRuleFile.Text))
                {
                    WriteStatus("Input 'File Template' cannot be empty.");
                    return;
                }

                templateCore.DeleteRule(txtName.Text, txtRuleFile.Text);

                ScrenRuleControl(EnScrenRuleControl.Default);
                WriteStatus($"Deleted the '{txtName.Text}' rule from the '{txtRuleName.Text}' template");
                AddRuleInListBox(txtName.Text);
                ClearScrenRule();
            }
            catch (Exception ex)
            {
                WriteStatus($"Error trying to delete rule: {ex.Message}");
            }
        }

        private void btnRuleFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                // Filter by All Files
                dlg.Filter = "C#|*.cs;*.cshtml|All Files|*.*";
                dlg.Multiselect = false;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    PrepareRuleFile(dlg.FileName);
                }
            }
        }
        #endregion

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            txtPhysicalPath.Text = System.IO.Path.Combine(configuration.PhysicalPathTemplate, txtName.Text.Trim());
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            txtPhysicalPath.Text = System.IO.Path.Combine(configuration.PhysicalPathTemplate, txtName.Text.Trim());
        }

        private void lbTemplates_SelectedValueChanged(object sender, EventArgs e)
        {
            string templateName = lbTemplates?.SelectedItem?.ToString() ?? string.Empty;

            if (!string.IsNullOrEmpty(templateName))
            {
                Template template = templateCore.GetTemplate(templateName);

                txtName.Text = template.Name;
                txtPhysicalPath.Text = template.PhysicalPath;
                AddRuleInListBox(templateName);

                ScrenTemplateControl(EnScrenTemplateControl.Template);
                ScrenRuleControl(EnScrenRuleControl.Default);

                WriteStatus($"View details of the '{template.Name}' template");
            }
        }

        private void lbRules_SelectedValueChanged(object sender, EventArgs e)
        {
            string ruleName = lbRules?.SelectedItem?.ToString() ?? string.Empty;

            if (!string.IsNullOrEmpty(ruleName))
            {
                Template template = templateCore.GetTemplate(txtName.Text);
                TemplateRule rule = template.TemplateRules.FirstOrDefault(tr => tr.Name.Equals(ruleName));

                txtRuleFile.Text = rule.File;
                txtRuleTargeProjectNamespace.Text = rule.TargeNamespace;
                txtRuleName.Text = rule.Target;
                txtRuleNamespace.Text = rule.DestinationPath;
                chkRuleKeep.Checked = !rule.Overide;
                SetRichTextBox(templateCore.GetEditFile(rule));

                ScrenRuleControl(EnScrenRuleControl.Rule);

                WriteStatus($"View details of the '{template.Name}' rule of the '{rule.Name}' template");
            }
        }
        #endregion

    }
}

using LearningProject.DAL.Entity;
using LearningProject.DAL.Manager;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LearningProject.View.UC
{
    public partial class fFoodItem : Form
    {
        FoodItem _currentFoodItem = null;

        public fFoodItem()
        {
            InitializeComponent();

            dgvItems.AutoGenerateColumns = false;
            dgvStock.AutoGenerateColumns = false;
        }

        private void fFoodItem_Load(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                LoadDgvItems();
                LoadCbUOM();
            });
        }

        private void LoadCbUOM()
        {
            List<UnitOfMeasure> unitOfMeasures = DbManager.GetUnitOfMeasures();
            //unitOfMeasures.Insert(0, new UnitOfMeasure() { IsNull = true });

            cbUnitOfMesure.DataSource = unitOfMeasures;
        }

        private void LoadDgvItems()
        {
            List<FoodItem> foodItems = DbManager.GetFoodItems();
            dgvItems.DataSource = foodItems;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            string name = tbName.Text.Trim();
            string description = tbDescription.Text.Trim();

            string category = cbCategory.Text.Trim();

            UnitOfMeasure unitOfMeasure = cbUnitOfMesure.SelectedItem as UnitOfMeasure;

            decimal alertThreshold = nudAlertThreshold.Value;

            #region check 

            string errorMsg = null;

            if (name == string.Empty)
            {
                errorMsg = "Veuillez saisir le nom de l'article.";
                tbName.Focus(); tbName.Select();
            }

            if (errorMsg != null)
            {
                MessageBox.Show(errorMsg, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            #endregion

            bool success = false;

            if (_currentFoodItem == null)
            {
                success = DbManager.InsertFoodItem(name, unitOfMeasure?.id, description, alertThreshold, category);
            }
            else
            {
                success = DbManager.UpdateFoodItem(_currentFoodItem.id, name, unitOfMeasure?.id, description, alertThreshold, category);
            }

            if (success)
            {
                MessageBox.Show("Opération effectuée avec succès !");
                LoadDgvItems();
                InitFormItem();
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            ShowDetailItem();
        }

        private void ShowDetailItem()
        {
            if (dgvItems.SelectedRows.Count > 0 && dgvItems.SelectedRows[0].DataBoundItem is FoodItem foodItem)
            {

                OpenFoodItem(foodItem);
                _currentFoodItem = foodItem;
            }
            else
            {
                MessageBox.Show("Veuillez choisir un aliment.", "Choix requis", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void OpenFoodItem(FoodItem foodItem)
        {
            this._currentFoodItem = foodItem;

            tbName.Text = foodItem.name;
            tbDescription.Text = foodItem.description;

            cbCategory.Text = foodItem.category;

            cbUnitOfMesure.SelectedItem = foodItem.UnitOfMeasure;

            nudAlertThreshold.Value = foodItem.alertThreshold;
            nudStockQuantity.Value = foodItem.stockQuantity;

            List<StockEntryDetail> stockDetails = DbManager.GetStockEntryDetails(
                _foodItemId: _currentFoodItem.id,
                _onlyInStock: true
            );
            dgvStock.DataSource = stockDetails;

            tabControl.SelectedTab = tpForm;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDgvItems();
        }

        private void btnNew1_Click(object sender, EventArgs e)
        {
            AddNewFoodItem();
        }

        private void btnNew2_Click(object sender, EventArgs e)
        {
            AddNewFoodItem();
        }

        private void AddNewFoodItem()
        {
            InitFormItem();
            tabControl.SelectedTab = tpForm;
        }

        private void InitFormItem()
        {
            this._currentFoodItem = null;

            tbName.Clear();
            tbDescription.Clear();

            cbCategory.Text = string.Empty;

            cbUnitOfMesure.SelectedItem = null;

            nudAlertThreshold.Value = 0;
            nudStockQuantity.Value = 0;

            dgvStock.DataSource = new List<StockEntryDetail>();

            this.ActiveControl = tbName;
        }

        private void btnInitForm_Click(object sender, EventArgs e)
        {
            InitFormItem();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_currentFoodItem != null)
            {
                if (DialogResult.Yes == MessageBox.Show("Voulez-vous vraiment supprimer cet aliment ? Cette action est irreversible !", "Suppression", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3))
                {
                    bool result = DbManager.DeleteFoodItem(_currentFoodItem.id);
                    if (result)
                    {
                        MessageBox.Show("Opération de suppression effectuée avec succès.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDgvItems();

                        InitFormItem();
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la suppression !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}

using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics
{
    /// <summary>
    /// √лавна€ форма
    /// </summary>
    public partial class MainForm : Form
    {
        private Store _shop = new Store();

        /// <summary>
        /// —войство магазина главной формы, который хранит списки товаров и покупателей.
        /// </summary>
        public Store Shop
        {
            get
            {
                return _shop;
            }
            set
            {
                _shop = value;
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CustomersControlTab.Customers = Shop.Customers;
            ItemsControlTab.Items = Shop.Items;
        }
    }
}

using MaterialSkin;
using MaterialSkin.Controls;

namespace SimplyU
{
    public partial class dev_rednand_prepare : MaterialForm
    {
        public dev_rednand_prepare()
        {
            InitializeComponent();
            MaterialSkinManager.Instance.AddFormToManage(this);
        }
    }
}
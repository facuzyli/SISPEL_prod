using System.Linq;
using System.Windows.Forms;
using SISPEL.Service.Facade;

namespace SISPEL.UI.Forms;
public partial class FrmClientes : Form
{
    private readonly SispelFacade _facade = new();

    public FrmClientes()
    {
        InitializeComponent();
        Load += (s, e) => dgvClientes.DataSource = _facade.ListarClientes().ToList();
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;


namespace WinFrmKzvl
{
    public partial class FrmGroup : Form
    {
        private KZVLDataEF.KZVLEntities ctx;

        public FrmGroup()
        {
            InitializeComponent();
            ctx = new KZVLDataEF.KZVLEntities();

            ctx.Groups.Load();
            ctx.Players.Load();
            ctx.Divizions.Load();

            this.groupsBindingSource.DataSource = ctx.Groups.Local.ToBindingList();
            this.playersBindingSource.DataSource = ctx.Players.Local.ToBindingList();
            this.divizionsBindingSource.DataSource = ctx.Divizions.Local.ToBindingList();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            ctx.Dispose();
            ctx = new KZVLDataEF.KZVLEntities();

            var player = (from c in ctx.Players select c);
            var group = (from c in ctx.Groups select c);
            var divizion = (from c in ctx.Divizions select c);

            if (!string.IsNullOrWhiteSpace(comboBoxName.Text))
            {
                group = group.Where(g => g.GR_Name.Contains(comboBoxName.Text));
            }

            if (!string.IsNullOrWhiteSpace(comboBoxBestPlayer.Text))
            {
                player = player.Where(p => p.PL_Name.Contains(comboBoxBestPlayer.Text));
                group = group.Where(g => g.GR_BestPlayer_Players_Id == player.FirstOrDefault().PL_Id);
            }

            if (!string.IsNullOrWhiteSpace(comboBoxNumber.Text))
            {
                int res = int.Parse(comboBoxNumber.Text);

                divizion = divizion.Where(d => d.DZ_Number == res);
                group = group.Where(g => g.GR_Divizion_Divizions_Id == divizion.FirstOrDefault().DZ_Id);
            }

            group.Load();

            this.groupsBindingSource.DataSource = ctx.Groups.Local.ToBindingList();
        }
    }
}

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
    public partial class FrmPlayer : Form
    {
        private KZVLDataEF.KZVLEntities ctx;

        public FrmPlayer()
        {
            InitializeComponent();
            ctx = new KZVLDataEF.KZVLEntities();
            ctx.Teams.Load();
            ctx.Players.Load();
            ctx.Role.Load();

            this.teamsBindingSource.DataSource = ctx.Teams.Local.ToBindingList();
            this.playersBindingSource.DataSource = ctx.Players.Local.ToBindingList();
            this.roleBindingSource.DataSource = ctx.Role.Local.ToBindingList();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            ctx.Dispose();
            ctx = new KZVLDataEF.KZVLEntities();

            var team = (from c in ctx.Teams select c);
            var player = (from c in ctx.Players select c);
            var role = (from c in ctx.Role select c);

            if (!string.IsNullOrWhiteSpace(comboBoxName.Text))
            {
                player = player.Where(p => p.PL_Name.Contains(comboBoxName.Text));
            }

            if (!string.IsNullOrWhiteSpace(comboBoxNumber.Text))
            {
                player = player.Where(p => p.PL_Number == int.Parse(comboBoxNumber.Text));
            }

            if (!string.IsNullOrWhiteSpace(comboBoxHeight.Text))
            {
                int res = int.Parse(comboBoxHeight.Text);
                player = player.Where(p => p.PL_Height == res);
            }

            if (!string.IsNullOrWhiteSpace(comboBoxRole.Text))
            {
                role = role.Where(r => r.RL_Name.Contains(comboBoxRole.Text));
                player = player.Where(p => p.PL_Role_Role_Id == role.FirstOrDefault().RL_Id);
            }

            if (!string.IsNullOrWhiteSpace(comboBoxTeam.Text))
            {
                team = team.Where(t => t.TM_Name.Contains(comboBoxTeam.Text));
                player = player.Where(p => p.PL_Team_Teams_Id == team.FirstOrDefault().TM_Id);
            }

            if (!string.IsNullOrWhiteSpace(comboBoxCountOfTheBestPlayer.Text))
            {
                int res = int.Parse(comboBoxCountOfTheBestPlayer.Text);

                player = player.Where(p => p.PL_CountOfBestPlayerMatch == res);
            }

            if (!string.IsNullOrWhiteSpace(comboBoxCategory.Text))
            {
                player = player.Where(p => p.PL_Category.Contains(comboBoxCategory.Text));
            }

            player.Load();

            this.playersBindingSource.DataSource = ctx.Players.Local.ToBindingList();
        }
    }
}

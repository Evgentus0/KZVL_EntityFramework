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
    public partial class FrmTeam : Form
    {
        private KZVLDataEF.KZVLEntities ctx;

        public FrmTeam()
        {
            InitializeComponent();
            ctx = new KZVLDataEF.KZVLEntities();
            ctx.Teams.Load();
            ctx.Players.Load();
            ctx.Groups.Load();

            this.teamsBindingSource.DataSource = ctx.Teams.Local.ToBindingList();
            this.playersBindingSource.DataSource = ctx.Players.Local.ToBindingList();
            this.groupsBindingSource.DataSource = ctx.Groups.Local.ToBindingList();

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            ctx.Dispose();
            ctx = new KZVLDataEF.KZVLEntities();

            var team = (from c in ctx.Teams select c);
            var player = (from c in ctx.Players select c);
            var group = (from c in ctx.Groups select c);
            
            if (!string.IsNullOrWhiteSpace(comboBoxName.Text))
            {
                team = team.Where(c => c.TM_Name.Contains(comboBoxName.Text));
            }

            if (!string.IsNullOrWhiteSpace(comboBoxRating.Text))
            {
                int res = int.Parse(comboBoxRating.Text);

                team = team.Where(c => c.TM_Rating == res);
            }

            if (!string.IsNullOrWhiteSpace(comboBoxCaptain.Text))
            {
                player = player.Where(c => c.PL_Name.Contains(comboBoxCaptain.Text));
                team = team.Where(t => t.TM_Captain_Players_Id == player.FirstOrDefault().PL_Id);
            }

            if (!string.IsNullOrWhiteSpace(comboBoxGroup.Text))
            {
                group = group.Where(c => c.GR_Name.Contains(comboBoxGroup.Text));
                team = team.Where(c => c.TM_Group_Groups_Id == group.FirstOrDefault().GR_Id);
            }

            team.Load();

            this.teamsBindingSource.DataSource = ctx.Teams.Local.ToBindingList();
        }
    }
}

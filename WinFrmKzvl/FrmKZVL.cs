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
    public partial class FrmKZVL : Form
    {
        private KZVLDataEF.KZVLEntities ctx;

        public FrmKZVL()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            ctx = new KZVLDataEF.KZVLEntities();

            ctx.Teams.Load();
            this.teamsBindingSource.DataSource = ctx.Teams.Local.ToBindingList();

            ctx.Players.Load();
            this.playersBindingSource.DataSource = ctx.Players.Local.ToBindingList();

            ctx.Groups.Load();
            this.groupsBindingSource.DataSource = ctx.Groups.Local.ToBindingList();

            ctx.Divizions.Load();
            this.divizionsBindingSource.DataSource = ctx.Divizions.Local.ToBindingList();

            ctx.Role.Load();
            this.roleBindingSource.DataSource = ctx.Role.Local.ToBindingList();
        }

        private void buttonSaveTeams_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void buttonSavePlayers_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void buttonSaveGroups_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void buttonSaveDivizions_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void buttonSaveRole_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void buttonDeleteTeams_Click(object sender, EventArgs e)
        {
            try
            {
                KZVLDataEF.Teams teams = (KZVLDataEF.Teams)dataGridViewTeams.CurrentRow.DataBoundItem;
                var b = (from c in ctx.Players where c.Teams.TM_Id == teams.TM_Id select c).Any();
                if (b)
                {
                    MessageBox.Show("Видаляти не можна, у команді є гравці!");
                }
                else
                {
                    teamsBindingSource.RemoveCurrent();
                }
            }
            catch
            {
                MessageBox.Show("Помилка при читанні команд");
            }
        }

        private void buttonDeletePlayers_Click(object sender, EventArgs e)
        {
            try
            {
                KZVLDataEF.Players players = (KZVLDataEF.Players)dataGridViewPlayers.CurrentRow.DataBoundItem;
                var b = (from c in ctx.Groups where c.Players.PL_Id == players.PL_Id select c).Any();
                if (b)
                {
                    MessageBox.Show("Видаляти не можна! Кращий гравець групи");
                }
                else
                {
                    playersBindingSource.RemoveCurrent();
                }
            }
            catch
            {
                MessageBox.Show("помилка при читанні гравця");
            }
        }

        private void buttonDeleteGroups_Click(object sender, EventArgs e)
        {
            try
            {
                KZVLDataEF.Groups groups = (KZVLDataEF.Groups)dataGridViewGroups.CurrentRow.DataBoundItem;
                var b = (from c in ctx.Teams where c.Groups.GR_Id == groups.GR_Id select c).Any();
                if (b)
                {
                    MessageBox.Show("Видаляти не можна, у групі є команди");
                }
                else
                {
                    groupsBindingSource.RemoveCurrent();
                }
            }
            catch
            {
                MessageBox.Show("помилка при читанні групи");
            }
        }

        private void tabDivizions_Click(object sender, EventArgs e)
        {
            try
            {
                KZVLDataEF.Divizions divizions = (KZVLDataEF.Divizions)dataGridViewDivizions.CurrentRow.DataBoundItem;
                var b = (from c in ctx.Groups where c.Divizions.DZ_Id == divizions.DZ_Id select c).Any();
                if (b)
                {
                    MessageBox.Show("видаляти не можна! у дивізіоні є команди");
                }
                else
                {
                    divizionsBindingSource.RemoveCurrent();
                }
            }
            catch
            {
                MessageBox.Show("помилка при читанні дивізіону");
            }
        }
    }
}

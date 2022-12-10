using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LadderTracker
{
    public partial class MainView : Form
    {
        public MainView()
        {
            DBManager.Init();
            InitializeComponent();
            RefreshView();
        }

        private void RefreshView()
        {
            this.seasonView.Rows.Clear();
            foreach (Season s in DBManager.seasons.FindAll())
            { 
                this.seasonView.Rows.Add(s.Id, s.SeasonName, s.StartDate.ToString("MM/dd/yy"), s.EndDate.ToString("MM/dd/yy"));
                seasonView.Rows[seasonView.Rows.Count - 1].ReadOnly = true;
            }
            seasonView.Refresh();

            this.sessionView.Rows.Clear();
            foreach (Session s in DBManager.sessions.FindAll())
            {
                this.sessionView.Rows.Add(s.Id, s.IDSeason, s.StartTime.ToString("MM/dd/yy, hh:mm") + s.StartTime.ToString("tt"), s.EndTime.ToString("MM/dd/yy, hh:mm") + s.EndTime.ToString("tt"), s.TankWin, s.TankLoss, s.DamageWin, s.DamageLoss, s.SupportWin, s.SupportLoss);
                sessionView.Rows[sessionView.Rows.Count - 1].ReadOnly = true;
            }
            sessionView.Refresh();
        }

        private void addNewSeasonButton_Click(object sender, EventArgs e)
        {
            DBManager.AddNewSeason();
            RefreshView();
        }

        private void editSeasonButton_Click(object sender, EventArgs e)
        {
            addNewSeasonButton.Enabled = false;
            addNewSessionButton.Enabled = false;
            editSeasonButton.Enabled = false;
            editSessionButton.Enabled = false;
            deleteSeasonButton.Visible = true;
            saveSeasonButton.Visible = true;

            Season s = DBManager.seasons.FindById((int)seasonView.SelectedRows[0].Cells[0].Value);

            foreach (DataGridViewRow r in seasonView.Rows)
            {
                if (s.Id == (int)r.Cells[0].Value)
                {
                    r.ReadOnly = false;
                }
                else
                {
                    r.Visible = false;
                }
            }
        }

        private void deleteSeasonButton_Click(object sender, EventArgs e)
        {
            addNewSeasonButton.Enabled = true;
            addNewSessionButton.Enabled = true;
            editSeasonButton.Enabled = true;
            editSessionButton.Enabled = true;
            deleteSeasonButton.Visible = false;
            saveSeasonButton.Visible = false;

            DBManager.DeleteSeason((int)seasonView.SelectedRows[0].Cells[0].Value);
            RefreshView();
        }

        private void saveSeasonButton_Click(object sender, EventArgs e)
        {
            addNewSeasonButton.Enabled = true;
            addNewSessionButton.Enabled = true;
            editSeasonButton.Enabled = true;
            editSessionButton.Enabled = true;
            deleteSeasonButton.Visible = false;
            saveSeasonButton.Visible = false;

            Season s = DBManager.seasons.FindById((int)seasonView.SelectedRows[0].Cells[0].Value);

            s.SeasonName = seasonView.SelectedRows[0].Cells[1].Value.ToString();
            s.StartDate = DateTime.Parse(seasonView.SelectedRows[0].Cells[2].Value.ToString());
            s.EndDate = DateTime.Parse(seasonView.SelectedRows[0].Cells[3].Value.ToString());

            foreach (DataGridViewRow r in seasonView.Rows)
            {
                if (s.Id == (int)r.Cells[0].Value)
                {
                    r.ReadOnly = true;
                }
                else
                {
                    r.Visible = true;
                }
            }

            DBManager.seasons.Update(s);
        }

        private void addNewSessionButton_Click(object sender, EventArgs e)
        {
            DBManager.AddNewSession();
            RefreshView();
        }

        private void editSessionButton_Click(object sender, EventArgs e)
        {
            addNewSeasonButton.Enabled = false;
            addNewSessionButton.Enabled = false;
            editSeasonButton.Enabled = false;
            editSessionButton.Enabled = false;
            deleteSessionButton.Visible = true;
            saveSessionButton.Visible = true;
            tankGroupBox.Visible = true;
            damageGroupBox.Visible = true;
            supportGroupBox.Visible = true;

            Session s = DBManager.sessions.FindById((int)sessionView.SelectedRows[0].Cells[0].Value);

            foreach (DataGridViewRow r in sessionView.Rows)
            {
                if (s.Id == (int)r.Cells[0].Value)
                {
                    r.ReadOnly = false;
                }
                else
                {
                    r.Visible = false;
                }
            }

        }

        private void deleteSessionButton_Click(object sender, EventArgs e)
        {
            addNewSeasonButton.Enabled = true;
            addNewSessionButton.Enabled = true;
            editSeasonButton.Enabled = true;
            editSessionButton.Enabled = true;
            deleteSessionButton.Visible = false;
            saveSessionButton.Visible = false;
            tankGroupBox.Visible = false;
            damageGroupBox.Visible = false;
            supportGroupBox.Visible = false;

            DBManager.DeleteSession((int)sessionView.SelectedRows[0].Cells[0].Value);
            RefreshView();
        }


        private void saveSessionButton_Click(object sender, EventArgs e)
        {
            addNewSeasonButton.Enabled = true;
            addNewSessionButton.Enabled = true;
            editSeasonButton.Enabled = true;
            editSessionButton.Enabled = true;
            deleteSessionButton.Visible = false;
            saveSessionButton.Visible = false;
            tankGroupBox.Visible = false;
            damageGroupBox.Visible = false;
            supportGroupBox.Visible = false;

            Session s = DBManager.sessions.FindById((int)sessionView.SelectedRows[0].Cells[0].Value);

            s.IDSeason = (int)sessionView.SelectedRows[0].Cells[1].Value;
            s.StartTime = DateTime.Parse(sessionView.SelectedRows[0].Cells[2].Value.ToString());
            s.EndTime = DateTime.Parse(sessionView.SelectedRows[0].Cells[3].Value.ToString());
            //s.TankWin = 

            /*s.SeasonName = seasonView.SelectedRows[0].Cells[1].Value.ToString();
            s.StartDate = DateTime.Parse(seasonView.SelectedRows[0].Cells[2].Value.ToString());
            s.EndDate = DateTime.Parse(seasonView.SelectedRows[0].Cells[3].Value.ToString());

            foreach (DataGridViewRow r in seasonView.Rows)
            {
                if (s.Id == (int)r.Cells[0].Value)
                {
                    r.ReadOnly = true;
                }
                else
                {
                    r.Visible = true;
                }
            }

            DBManager.seasons.Update(s);*/
        }
    }
}
